using UnityEngine;

namespace LSW{

	[System.Serializable] public partial class GameController : ScriptableObject {
	
		GameController Instance;
		GameController() {
		
			Instance = this;
		}
	}
}