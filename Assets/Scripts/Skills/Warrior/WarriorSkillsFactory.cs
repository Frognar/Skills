using System.Collections.Generic;
using System.Linq;
using skills.Application;

namespace skills.Skills.Warrior {
	public class WarriorSkillsFactory : Factory {
		readonly Dictionary<string, Command> skills;

		public WarriorSkillsFactory() {
			skills = new Dictionary<string, Command> {{"Hit", new Hit()}, {"Charge", new Charge()}};
		}

		public Command Make(string name) {
			return skills[name];
		}

		public List<string> GetObjectsNames() {
			return skills.Keys.ToList();
		}
	}
}