using System.Text;

namespace LSW
{

	[System.Serializable]
	public struct DataDefinition_Limits
	{
		public int ID;
		public double Minimum;
		public double Maximum;
		public StringBuilder DataDefinition_Name;
		public StringBuilder DataDefinition_FieldName;
	}
}