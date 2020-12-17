using System.Collections.Generic;
using skills.Application;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace skills.UI {
	public class SkillUI : MonoBehaviour, SkillView {
		Transform template;
		List<Transform> buttons;
		
		void Awake() {
			buttons = new List<Transform>();
			template = transform.GetChild(0);
			template.gameObject.SetActive(false);
		}

		public void ResetView() {
			foreach (Transform button in buttons)
				Destroy(button.gameObject);
			buttons.Clear();
		}

		public void CreateSkillInteractor(string skillName, UnityAction skillAction) {
			Transform newBtn = CreateBtnTransform();
			SetText(newBtn, skillName);
			SetAction(newBtn, skillAction);
			buttons.Add(newBtn);
		}

		Transform CreateBtnTransform() {
			Transform btn = Instantiate(template, CalculatePosition(), Quaternion.identity, transform);
			btn.gameObject.SetActive(true);
			return btn;
		}

		Vector3 CalculatePosition() {
			return template.position + Vector3.right * (110 * buttons.Count);
		}

		static void SetText(Component btn, string text) {
			btn.GetComponentInChildren<TMP_Text>().text = text;
		}
		
		static void SetAction(Component btn, UnityAction onClick){
			btn.GetComponentInChildren<Button>().onClick.AddListener(onClick);
		}
	}
}