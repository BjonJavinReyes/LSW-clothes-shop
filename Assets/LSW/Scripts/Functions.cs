using UnityEngine;

namespace LSW
{
	public partial class Functions:ScriptableObject
	{
		Functions Instance;
		Functions() {
			Instance = this;
		}
	}
}