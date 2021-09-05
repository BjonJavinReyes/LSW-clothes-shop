using System;

namespace LSW{

	[System.Serializable] public struct DataDefinition_TransactionResult

	{ public System.Int64  ID;
		public enum TransactionStatus {
			Talk,
			Bought,
			Refunded,
			Swapped,
			Rejected
		};
	}
}