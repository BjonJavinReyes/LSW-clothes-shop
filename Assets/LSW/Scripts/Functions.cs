using UnityEngine;

namespace LSW{
	[CreateAssetMenu(menuName = "LSW/Functions", fileName = "Functions")]
	[System.Serializable] public partial class Functions:ScriptableObject {
	
		Functions Instance;
		Functions() { 
			Instance = this;
		}
	}
}