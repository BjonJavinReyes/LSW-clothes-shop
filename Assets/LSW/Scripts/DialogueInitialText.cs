using System.Text;
using Unity.Collections;

namespace LSW
{

	[System.Serializable]
	public struct DataDefinition_DialogueInitialText

	{
		public System.Int64 ID;
		public System.Int64 PlaceHolderTextID;
		public FixedString128Bytes Text;
	}
}