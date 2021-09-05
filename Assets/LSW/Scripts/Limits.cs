using System.Text;
using Unity.Collections;

namespace LSW
{

	[System.Serializable]
	public struct DataDefinition_Limits
	{
		public System.Int64  ID;
		public System.Double Minimum;
		public System.Double Maximum;
		public FixedString128Bytes DataDefinition_Name;
		public FixedString128Bytes DataDefinition_FieldName;
	}
}