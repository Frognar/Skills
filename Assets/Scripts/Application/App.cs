using skills.Application.NullObjects;

namespace skills.Application {
    public class App {
        Factory skillFactory;
        SkillView skillView;
        
        public App() {
            skillFactory = new NullFactory();
            skillView = new NullSkillView();
        }
        
        public void ConnectFactory(Factory factory) {
            skillFactory = factory;
        }

        public void ConnectSkillView(SkillView view) {
            skillView = view;
        }

        public void UpdateView() {
            skillView.ResetView();
            foreach (string skillName in skillFactory.GetObjectsNames())
                skillView.CreateSkillInteractor(skillName, () => skillFactory.Make(skillName).Execute());
        }
    }
}
