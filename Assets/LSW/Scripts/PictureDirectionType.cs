namespace LSW
{

	[System.Serializable]
	public struct DataDefinition_PictureDirectionType

	{
		public int ID;
		public enum Direction
		{
			Forward,
			Backward,
			Left,
			Right
		}
	}
}