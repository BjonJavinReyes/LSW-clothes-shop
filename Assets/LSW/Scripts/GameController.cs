using UnityEngine;

namespace LSW
{
	public partial class GameController : ScriptableObject
	{
		GameController Instance;
		GameController()
		{
			Instance = this;
		}
	}
}