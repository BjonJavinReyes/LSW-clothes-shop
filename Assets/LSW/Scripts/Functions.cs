using Unity.Burst;
using UnityEngine;

namespace LSW{
	[BurstCompile]
	[CreateAssetMenu(menuName = "LSW/Functions", fileName = "Functions")]
	[System.Serializable] 
	public partial class Functions:ScriptableObject {
	
		public static Functions Instance;
		Functions() { 
			Instance = this;
		}

		
	}
}