using System.Collections.Generic;
using UnityEngine;

namespace LSW{
	[CreateAssetMenu(menuName = "LSW/Application References", fileName = "Application References")]
	[System.Serializable] public partial class ApplicationReferences : ScriptableObject {
	
		ApplicationReferences Instance;
		ApplicationReferences() {
		
			Instance = this;
		}

		public List<DataDefinition_BuyerPicture> InstanceList_BuyerPicture = new List<DataDefinition_BuyerPicture>();
		public List<DataDefinition_ItemPicture> InstanceList_ItemPicture = new List<DataDefinition_ItemPicture>();
		public List<DataDefinition_SellerPicture> InstanceList_SellerPicture = new List<DataDefinition_SellerPicture>();
		public List<DataDefinition_ShopkeeperPicture> InstanceList_ShopkeeperPicture = new List<DataDefinition_ShopkeeperPicture>();

	}
}