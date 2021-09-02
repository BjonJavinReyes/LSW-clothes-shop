using UnityEngine;

namespace LSW
{
	public partial class ApplicationReferences : ScriptableObject
	{
		ApplicationReferences Instance;
		ApplicationReferences()
		{
			Instance = this;
		}
	}
}