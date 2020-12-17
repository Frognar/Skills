using System.Collections.Generic;

namespace skills.Application {
	public interface Factory {
		Command Make(string name);
		List<string> GetObjectsNames();
	}
}