using System.Collections.Generic;
using System.Linq;
using skills.Application;

namespace skills.Skills.Mage {
    public class MageSkillsFactory : Factory {
        readonly Dictionary<string, Command> skills;

        public MageSkillsFactory() {
            skills = new Dictionary<string, Command> {
                                                         {"Fireball", new Fireball()},
                                                         {"Sleep", new Sleep()},
                                                         {"Summon", new Summon()}
                                                     };

        }
        
        public Command Make(string name) {
            return skills[name];
        }

        public List<string> GetObjectsNames() {
            return skills.Keys.ToList();
        }
    }
}
