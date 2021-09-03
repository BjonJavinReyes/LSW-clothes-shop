using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace LSW
{
	[CreateAssetMenu(menuName = "LSW/Application Variables", fileName = "Application Variables")]
	[System.Serializable]
	public partial class ApplicationVariables : ScriptableObject
	{

		ApplicationVariables Instance;
		ApplicationVariables()
		{

			Instance = this;
		}

		public List<DataDefinition_BodyPartID> InstanceList_BodyPartID = new List<DataDefinition_BodyPartID>();
		public List<DataDefinition_Limits> InstanceList_Limits = new();
		public List<DataDefinition_BodyPartIDToBodyPartInitialName> InstanceList_BodyPartIDToBodyPartInitialName = new();
		public List<DataDefinition_BodyPartInitialName> InstanceList_BodyPartInitialName = new();
		public List<DataDefinition_BuyerID> InstanceList_BuyerID = new();
		public List<DataDefinition_BuyerIDToBuyerInitialName> InstanceList_BuyerIDToBuyerInitialName = new();
		public List<DataDefinition_BuyerInitialName> InstanceList_BuyerInitialName = new();

		public List<DataDefinition_DialogueID> InstanceList_DialogueID = new();
		public List<DataDefinition_DialogueIDToDialogueIDOfResponse> InstanceList_DialogueIDToDialogueIDOfResponse = new();
		public List<DataDefinition_DialogueIDToDialogueInitialText> InstanceList_DialogueIDToDialogueInitialText = new();
		public List<DataDefinition_DialogueInitialText> InstanceList_DialogueInitialText = new();
		public List<DataDefinition_DiscountID> InstanceList_DiscountID = new();
		public List<DataDefinition_DiscountIDToDiscountInDecimal> InstanceList_DiscountIDToDiscountInDecimal = new();
		public List<DataDefinition_DiscountIDToDiscountInPercent> InstanceList_DiscountIDToDiscountInPercent = new();
		public List<DataDefinition_DiscountInDecimal> InstanceList_DiscountInDecimal = new();
		public List<DataDefinition_DiscountInPercent> InstanceList_DiscountInPercent = new();
		public List<DataDefinition_EquipActionID> InstanceList_EquipActionID = new();
		public List<DataDefinition_EquipActionIDToBodyPartID> InstanceList_EquipActionIDToBodyPartID = new();
		public List<DataDefinition_EquipActionIDToBuyerID> InstanceList_EquipActionIDToBuyerID = new();
		public List<DataDefinition_EquipActionIDToDate> InstanceList_EquipActionIDToDate = new();
		public List<DataDefinition_EquipActionIDToProductID> InstanceList_EquipActionIDToProductID = new();

		public List<DataDefinition_ItemColor> InstanceList_ItemColor = new();
		public List<DataDefinition_ItemColorID> InstanceList_ItemColorID = new();
		public List<DataDefinition_ItemColorIDToItemColor> InstanceList_ItemColorIDToItemColor = new();
		public List<DataDefinition_ItemColorIDToItemColorInitialName> InstanceList_ItemColorIDToItemColorInitialName = new();
		public List<DataDefinition_ItemColorInitialName> InstanceList_ItemColorInitialName = new();
		public List<DataDefinition_ItemIcon> InstanceList_ItemIcon = new();
		public List<DataDefinition_ItemID> InstanceList_ItemID = new();
		public List<DataDefinition_ItemIDToItemIcon> InstanceList_ItemIDToItemIcon = new();
		public List<DataDefinition_ItemIDToItemTypeID> InstanceList_ItemIDToItemTypeID = new();
		public List<DataDefinition_ItemIDToPriceID> InstanceList_ItemIDToPriceID = new();
		public List<DataDefinition_ItemIDToStock> InstanceList_ItemIDToStock = new();

		public List<DataDefinition_ItemSize> InstanceList_ItemSize = new();
		public List<DataDefinition_ItemSizeID> InstanceList_ItemSizeID = new();
		public List<DataDefinition_ItemSizeIDToItemSize> InstanceList_ItemSizeIDToItemSize = new();
		public List<DataDefinition_ItemSizeIDToItemSizeInitialName> InstanceList_ItemSizeIDToItemSizeInitialName = new();
		public List<DataDefinition_ItemSizeInitialName> InstanceList_ItemSizeInitialName = new();
		public List<DataDefinition_ItemTypeID> InstanceList_ItemTypeID = new();
		public List<DataDefinition_ItemTypeIDToItemTypeInitialName> InstanceList_ItemTypeIDToItemTypeInitialName = new();
		public List<DataDefinition_ItemTypeIDToItemXYZPositionID> InstanceList_ItemTypeIDToItemXYZPositionID = new();
		public List<DataDefinition_ItemTypeIDToLocationID> InstanceList_ItemTypeIDToLocationID = new();
		public List<DataDefinition_ItemTypeIDToStoreID> InstanceList_ItemTypeIDToStoreID = new();
		public List<DataDefinition_ItemTypeInitialName> InstanceList_ItemTypeInitialName = new();
		public List<DataDefinition_ItemXYZPosition> InstanceList_ItemXYZPosition = new();
		public List<DataDefinition_LanguageID> InstanceList_LanguageID = new();
		public List<DataDefinition_LanguageName> InstanceList_LanguageName = new();
		public List<DataDefinition_LocationID> InstanceList_LocationID = new();
		public List<DataDefinition_LocationName> InstanceList_LocationName = new();

		public List<DataDefinition_PictureDirectionType> InstanceList_PictureDirectionType = new();
		public List<DataDefinition_PictureIDToPictureDirectionTypeID> InstanceList_PictureIDToPictureDirectionTypeID = new();
		public List<DataDefinition_PlaceHolderTextID> InstanceList_PlaceHolderTextID = new();
		public List<DataDefinition_PlaceHolderTextIDToTextID> InstanceList_PlaceHolderTextIDToTextID = new();
		public List<DataDefinition_PlaceHolderTextValues> InstanceList_PlaceHolderTextValues = new();
		public List<DataDefinition_PriceID> InstanceList_PriceID = new();
		public List<DataDefinition_PriceIDToPriceInDecimal> InstanceList_PriceIDToPriceInDecimal = new();
		public List<DataDefinition_PriceInDecimal> InstanceList_PriceInDecimal = new();
		public List<DataDefinition_SellerID> InstanceList_SellerID = new();
		public List<DataDefinition_SellerIDToSellerInitialName> InstanceList_SellerIDToSellerInitialName = new();
		public List<DataDefinition_SellerIDToStoreID> InstanceList_SellerIDToStoreID = new();
		public List<DataDefinition_SellerInitialName> InstanceList_SellerInitialName = new();

		public List<DataDefinition_ShopkeeperID> InstanceList_ShopkeeperID = new();
		public List<DataDefinition_ShopkeeperIDToShopkeeperInitialName> InstanceList_ShopkeeperIDToShopkeeperInitialName = new();
		public List<DataDefinition_ShopkeeperIDToStoreID> InstanceList_ShopkeeperIDToStoreID = new();
		public List<DataDefinition_ShopkeeperInitialName> InstanceList_ShopkeeperInitialName = new();

		public List<DataDefinition_StoreID> InstanceList_StoreID = new();
		public List<DataDefinition_StoreIDToLocationID> InstanceList_StoreIDToLocationID = new();
		public List<DataDefinition_StoreIDToStoreInitialName> InstanceList_StoreIDToStoreInitialName = new();
		public List<DataDefinition_StoreInitialName> InstanceList_StoreInitialName = new();
		public List<DataDefinition_TextID> InstanceList_TextID = new();
		public List<DataDefinition_TextIDToLanguageID> InstanceList_TextIDToLanguageID = new();
		public List<DataDefinition_TextValues> InstanceList_TextValues = new();
		public List<DataDefinition_TransactionID> InstanceList_TransactionID = new();
		public List<DataDefinition_TransactionIDToBuyerID> InstanceList_TransactionIDToBuyerID = new();
		public List<DataDefinition_TransactionIDToDate> InstanceList_TransactionIDToDate = new();
		public List<DataDefinition_TransactionIDToProductID> InstanceList_TransactionIDToProductID = new();
		public List<DataDefinition_TransactionIDToSellerID> InstanceList_TransactionIDToSellerID = new();

		public List<DataDefinition_TransactionResult> InstanceList_TransactionResult = new();
		public List<DataDefinition_TransactionResultID> InstanceList_TransactionResultID = new();
		public List<DataDefinition_TransactionIDToTransactionResultID> InstanceList_TransactionIDToTransactionResultID = new();
		public List<DataDefinition_TransactionIDToItemQuantity> InstanceList_TransactionIDToItemQuantity = new();

	}
}