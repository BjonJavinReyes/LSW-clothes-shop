using System.Text;
using Unity.Collections;

namespace LSW
{

	[System.Serializable]
	public struct DataDefinition_AvatarIDToIP

	{
		public System.Int64  ID;
		public FixedString128Bytes String_IPAddress;
	}
}