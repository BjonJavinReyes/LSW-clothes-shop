using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

namespace LSW
{
	[BurstCompile]
	[CreateAssetMenu(menuName = "LSW/Application Variables", fileName = "Application Variables")]
	[System.Serializable]
	public partial class ApplicationVariables : ScriptableObject
	{

		public static ApplicationVariables Instance;
		ApplicationVariables()
		{

			Instance = this;
		}
		
		public System.Int64  BuyerMeetsSellerDialogueID = 0;
		[SerializeField] public NativeList<DataDefinition_AvatarID> InstanceCollections_AvatarID = new();
		public NativeList<DataDefinition_AvatarIDToIP> InstanceCollections_AvatarIDToIP = new();

		public NativeList<DataDefinition_BodyPartID> InstanceCollections_BodyPartID = new();
		public NativeList<DataDefinition_Limits> InstanceCollections_Limits = new();
		public NativeList<DataDefinition_BodyPartIDToBodyPartInitialName> InstanceCollections_BodyPartIDToBodyPartInitialName = new();
		public NativeList<DataDefinition_BodyPartInitialName> InstanceCollections_BodyPartInitialName = new();
		public NativeList<DataDefinition_BuyerID> InstanceCollections_BuyerID = new();
		public NativeList<DataDefinition_BuyerIDToBuyerInitialName> InstanceCollections_BuyerIDToBuyerInitialName = new();
		public NativeList<DataDefinition_BuyerInitialName> InstanceCollections_BuyerInitialName = new();

		public NativeList<DataDefinition_DialogueID> InstanceCollections_DialogueID = new();
		
		public NativeList<DataDefinition_DialogueIDToDialogueIDOfResponse> InstanceCollections_DialogueIDToDialogueIDOfResponse = new();
		public NativeList<DataDefinition_DialogueIDToDialogueInitialText> InstanceCollections_DialogueIDToDialogueInitialText = new();
		public NativeList<DataDefinition_DialogueInitialText> InstanceCollections_DialogueInitialText = new();
		public NativeList<DataDefinition_DiscountID> InstanceCollections_DiscountID = new();
		public NativeList<DataDefinition_DiscountIDToDiscountInDecimal> InstanceCollections_DiscountIDToDiscountInDecimal = new();
		public NativeList<DataDefinition_DiscountIDToDiscountInPercent> InstanceCollections_DiscountIDToDiscountInPercent = new();
		public NativeList<DataDefinition_DiscountInDecimal> InstanceCollections_DiscountInDecimal = new();
		public NativeList<DataDefinition_DiscountInPercent> InstanceCollections_DiscountInPercent = new();
		public NativeList<DataDefinition_EquipActionID> InstanceCollections_EquipActionID = new();
		public NativeList<DataDefinition_EquipActionIDToBodyPartID> InstanceCollections_EquipActionIDToBodyPartID = new();
		public NativeList<DataDefinition_EquipActionIDToBuyerID> InstanceCollections_EquipActionIDToBuyerID = new();
		public NativeList<DataDefinition_EquipActionIDToDate> InstanceCollections_EquipActionIDToDate = new();
		public NativeList<DataDefinition_EquipActionIDToProductID> InstanceCollections_EquipActionIDToProductID = new();

		public NativeList<DataDefinition_ItemColor> InstanceCollections_ItemColor = new();
		public NativeList<DataDefinition_ItemColorID> InstanceCollections_ItemColorID = new();
		public NativeList<DataDefinition_ItemColorIDToItemColor> InstanceCollections_ItemColorIDToItemColor = new();
		public NativeList<DataDefinition_ItemColorIDToItemColorInitialName> InstanceCollections_ItemColorIDToItemColorInitialName = new();
		public NativeList<DataDefinition_ItemColorInitialName> InstanceCollections_ItemColorInitialName = new();

		public NativeList<DataDefinition_ItemID> InstanceCollections_ItemID = new();
		public NativeList<DataDefinition_ItemIDToItemIcon> InstanceCollections_ItemIDToItemIcon = new();
		public NativeList<DataDefinition_ItemIDToItemTypeID> InstanceCollections_ItemIDToItemTypeID = new();
		public NativeList<DataDefinition_ItemIDToPriceID> InstanceCollections_ItemIDToPriceID = new();
		public NativeList<DataDefinition_ItemIDToStock> InstanceCollections_ItemIDToStock = new();

		public NativeList<DataDefinition_ItemSize> InstanceCollections_ItemSize = new();
		public NativeList<DataDefinition_ItemSizeID> InstanceCollections_ItemSizeID = new();
		public NativeList<DataDefinition_ItemSizeIDToItemSize> InstanceCollections_ItemSizeIDToItemSize = new();
		public NativeList<DataDefinition_ItemSizeIDToItemSizeInitialName> InstanceCollections_ItemSizeIDToItemSizeInitialName = new();
		public NativeList<DataDefinition_ItemSizeInitialName> InstanceCollections_ItemSizeInitialName = new();
		public NativeList<DataDefinition_ItemTypeID> InstanceCollections_ItemTypeID = new();
		public NativeList<DataDefinition_ItemTypeIDToItemTypeInitialName> InstanceCollections_ItemTypeIDToItemTypeInitialName = new();
		public NativeList<DataDefinition_ItemTypeIDToItemXYZPositionID> InstanceCollections_ItemTypeIDToItemXYZPositionID = new();
		public NativeList<DataDefinition_ItemTypeIDToLocationID> InstanceCollections_ItemTypeIDToLocationID = new();
		public NativeList<DataDefinition_ItemTypeIDToStoreID> InstanceCollections_ItemTypeIDToStoreID = new();
		public NativeList<DataDefinition_ItemTypeInitialName> InstanceCollections_ItemTypeInitialName = new();
		public NativeList<DataDefinition_ItemXYZPosition> InstanceCollections_ItemXYZPosition = new();
		public NativeList<DataDefinition_LanguageID> InstanceCollections_LanguageID = new();
		public NativeList<DataDefinition_LanguageName> InstanceCollections_LanguageName = new();
		public NativeList<DataDefinition_LocationID> InstanceCollections_LocationID = new();
		public NativeList<DataDefinition_LocationName> InstanceCollections_LocationName = new();

		public NativeList<DataDefinition_PictureDirectionType> InstanceCollections_PictureDirectionType = new();
		public NativeList<DataDefinition_PictureIDToPictureDirectionTypeID> InstanceCollections_PictureIDToPictureDirectionTypeID = new();
		public NativeList<DataDefinition_PlaceHolderTextID> InstanceCollections_PlaceHolderTextID = new();
		public NativeList<DataDefinition_PlaceHolderTextIDToTextID> InstanceCollections_PlaceHolderTextIDToTextID = new();
		public NativeList<DataDefinition_PlaceHolderTextValues> InstanceCollections_PlaceHolderTextValues = new();
		public NativeList<DataDefinition_PriceID> InstanceCollections_PriceID = new();
		public NativeList<DataDefinition_PriceIDToPriceInDecimal> InstanceCollections_PriceIDToPriceInDecimal = new();
		public NativeList<DataDefinition_PriceInDecimal> InstanceCollections_PriceInDecimal = new();
		public NativeList<DataDefinition_SellerID> InstanceCollections_SellerID = new();
		public NativeList<DataDefinition_SellerIDToSellerInitialName> InstanceCollections_SellerIDToSellerInitialName = new();
		public NativeList<DataDefinition_SellerIDToStoreID> InstanceCollections_SellerIDToStoreID = new();
		public NativeList<DataDefinition_SellerInitialName> InstanceCollections_SellerInitialName = new();

		public NativeList<DataDefinition_ShopkeeperID> InstanceCollections_ShopkeeperID = new();
		public NativeList<DataDefinition_ShopkeeperIDToShopkeeperInitialName> InstanceCollections_ShopkeeperIDToShopkeeperInitialName = new();
		public NativeList<DataDefinition_ShopkeeperIDToStoreID> InstanceCollections_ShopkeeperIDToStoreID = new();
		public NativeList<DataDefinition_ShopkeeperInitialName> InstanceCollections_ShopkeeperInitialName = new();

		public NativeList<DataDefinition_StoreID> InstanceCollections_StoreID = new();
		public NativeList<DataDefinition_StoreIDToLocationID> InstanceCollections_StoreIDToLocationID = new();
		public NativeList<DataDefinition_StoreIDToStoreInitialName> InstanceCollections_StoreIDToStoreInitialName = new();
		public NativeList<DataDefinition_StoreInitialName> InstanceCollections_StoreInitialName = new();
		public NativeList<DataDefinition_TextID> InstanceCollections_TextID = new();
		public NativeList<DataDefinition_TextIDToLanguageID> InstanceCollections_TextIDToLanguageID = new();
		public NativeList<DataDefinition_TextValues> InstanceCollections_TextValues = new();
		public NativeList<DataDefinition_TransactionID> InstanceCollections_TransactionID = new();
		public NativeList<DataDefinition_TransactionIDToBuyerID> InstanceCollections_TransactionIDToBuyerID = new();
		public NativeList<DataDefinition_TransactionIDToDate> InstanceCollections_TransactionIDToDate = new();
		public NativeList<DataDefinition_TransactionIDToProductID> InstanceCollections_TransactionIDToProductID = new();
		public NativeList<DataDefinition_TransactionIDToSellerID> InstanceCollections_TransactionIDToSellerID = new();

		public NativeList<DataDefinition_TransactionResult> InstanceCollections_TransactionResult = new();
		public NativeList<DataDefinition_TransactionStatusID> InstanceCollections_TransactionResultID = new();
		public NativeList<DataDefinition_TransactionIDToTransactionResultID> InstanceCollections_TransactionIDToTransactionResultID = new();
		public NativeList<DataDefinition_TransactionIDToItemQuantity> InstanceCollections_TransactionIDToItemQuantity = new();

		public NativeList<DataDefinition_BuyerIDToDialogueID> InstanceCollections_BuyerIDToDialogueID = new();
		public NativeList<DataDefinition_SellerIDToDialogueID> InstanceCollections_SellerIDToDialogueID = new();

	}
}