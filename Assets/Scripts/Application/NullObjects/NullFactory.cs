using System.Collections.Generic;

namespace skills.Application.NullObjects {
	public class NullFactory : Factory {
		readonly Command nullCommand;
		
		public NullFactory() {
			nullCommand = new NullCommand();
		}
		
		public Command Make(string name) {
			return nullCommand;
		}

		public List<string> GetObjectsNames() {
			return new List<string>();
		}
	}
}