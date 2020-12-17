using UnityEngine.Events;

namespace skills.Application {
	public interface SkillView {
		void ResetView();
		void CreateSkillInteractor(string skillName, UnityAction skillAction);
	}
}