using skills.Application;
using skills.Skills.Mage;
using skills.Skills.Warrior;
using skills.UI;
using UnityEngine;

namespace skills.Main {
	public class GameManager : MonoBehaviour {
		[SerializeField] bool warriorOrMage;
		bool prevWarriorOrMage;
		
		App app;

		void Awake() {
			app = new App();
			app.ConnectSkillView(FindObjectOfType<SkillUI>());
			if (warriorOrMage)
				app.ConnectFactory(new WarriorSkillsFactory());
			else
				app.ConnectFactory(new MageSkillsFactory());
		}

		void Start() {
			app.UpdateView();
		}

		void Update() {
			if (warriorOrMage != prevWarriorOrMage) {
				prevWarriorOrMage = warriorOrMage;
				if (warriorOrMage)
					app.ConnectFactory(new WarriorSkillsFactory());
				else
					app.ConnectFactory(new MageSkillsFactory());
				app.UpdateView();
			}
		}
	}
}
