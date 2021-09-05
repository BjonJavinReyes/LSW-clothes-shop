namespace LSW
{

	[System.Serializable]
	public struct DataDefinition_PictureDirectionType

	{
		public System.Int64  ID;
		public enum Direction
		{
			Forward,
			Backward,
			Left,
			Right
		}
	}
}