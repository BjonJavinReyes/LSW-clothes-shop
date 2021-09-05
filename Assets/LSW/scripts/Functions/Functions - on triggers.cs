using UnityEngine;
using UnityEngine.Assertions;
using System.Linq;
using Unity.Collections;
using Unity.Burst;

namespace LSW
{
	
	public partial class Functions : ScriptableObject
	{

		public void BuyerMeetsSeller(int BuyerID, System.Int64  SellerID, System.Int64  StoreID)
		{
			//ApplicationVariables.Instance.tra
			Assert.IsTrue(BuyerID >= 0);
			Assert.IsTrue(SellerID >= 0);
			Assert.IsTrue(ApplicationVariables.Instance.InstanceCollections_AvatarID.ToArray().ToArray().ToList().Exists(m => m.ID == BuyerID));
			Assert.IsTrue(ApplicationVariables.Instance.InstanceCollections_AvatarID.ToArray().ToArray().ToList().Exists(m => m.ID == SellerID));
			Assert.IsTrue(ApplicationVariables.Instance.InstanceCollections_BuyerID.ToArray().ToArray().ToList().Exists(m => m.ID == BuyerID));
			Assert.IsTrue(ApplicationVariables.Instance.InstanceCollections_SellerID.ToArray().ToArray().ToList().Exists(m => m.ID == SellerID));
			Assert.IsTrue(ApplicationVariables.Instance.InstanceCollections_StoreID.ToArray().ToArray().ToList().Exists(m => m.ID == StoreID));
			
			ApplicationVariables.Instance.InstanceCollections_BuyerIDToDialogueID.Add(
				new DataDefinition_BuyerIDToDialogueID
				{
					ID = BuyerID
				,
					DialogueID = ApplicationVariables.Instance.BuyerMeetsSellerDialogueID
				});



		}

	}

}