using skills.Application;
using UnityEngine;

namespace skills.Skills.Warrior {
	public class Hit : Command{
		public void Execute() {
			Debug.Log("Hit!");
		}
	}
}