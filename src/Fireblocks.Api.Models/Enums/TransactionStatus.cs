namespace Fireblocks.Api.Enums;

public enum TransactionStatus
{
	/// <summary>
	/// The transaction was submitted to the Fireblocks system and is being processed
	/// </summary>
	SUBMITTED = 1,

	/// <summary>
	/// Transaction is queued. Pending for another transaction to be processed
	/// </summary>
	QUEUED,

	/// <summary>
	/// The transaction is pending authorization by other users (as defined in the Transaction Authorization Policy)
	/// </summary>
	PENDING_AUTHORIZATION,

	/// <summary>
	/// The transaction is pending the initiator to sign the transaction
	/// </summary>
	PENDING_SIGNATURE,

	/// <summary>
	/// The transaction is pending broadcast to the blockchain network
	/// </summary>
	BROADCASTING,

	/// <summary>
	/// The transaction is pending manual approval as required by the 3rd party, usually an email approval
	/// </summary>
	PENDING_3RD_PARTY_MANUAL_APPROVAL,

	/// <summary>
	/// The transaction is pending approval by the 3rd party service (e.g exchange)
	/// </summary>
	PENDING_3RD_PARTY,

	/// <summary>
	/// Pending confirmation on the blockchain
	/// </summary>
	CONFIRMING,

	/// <summary>
	/// (Only for Aggregated transactions) One or more of of the transaction records have completed successfully
	/// </summary>
	PARTIALLY_COMPLETED,

	/// <summary>
	///  In case the AML screening feature is enabled, transaction is pending AML screening result
	/// </summary>
	PENDING_AML_SCREENING,

	/// <summary>
	/// Successfully completed
	/// </summary>
	COMPLETED,

	/// <summary>
	/// The transaction was cancelled or rejected by the user on the Fireblocks platform or by the 3rd party service from which the funds are withdrawn
	/// </summary>
	CANCELLED,

	/// <summary>
	/// The transaction was rejected by the Fireblocks system or by the 3rd party service
	/// </summary>
	REJECTED,

	/// <summary>
	/// The transaction was blocked due to a policy rule
	/// </summary>
	BLOCKED,

	/// <summary>
	/// The transaction has failed
	/// </summary>
	FAILED
}
