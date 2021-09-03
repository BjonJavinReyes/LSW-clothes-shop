using System;

namespace LSW{

	[System.Serializable] public struct DataDefinition_TransactionResult

	{ public int ID;
		public enum TransactionResult {
			Bought,
			Refunded,
			Swapped,
			Rejected
		};
	}
}