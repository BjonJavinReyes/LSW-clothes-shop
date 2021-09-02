using UnityEngine;

namespace LSW
{
	public partial class ApplicationVariables : ScriptableObject
	{
		ApplicationVariables Instance;
		ApplicationVariables()
		{
			Instance = this;
		}
	}
}