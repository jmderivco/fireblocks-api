namespace Fireblocks.Api.Enums;

public enum NetworkStatus
{
	/// <summary>
	/// Transaction that were dropped by the blockchain (for example wasn't accepted due to low fee)
	/// </summary>
	DROPPED = 1,

	/// <summary>
	/// Broadcasting to the blockchain
	/// </summary>
	BROADCASTING,

	/// <summary>
	/// Pending confirmations
	/// </summary>
	CONFIRMING,

	/// <summary>
	/// The transaction has failed at the blockchain
	/// </summary>
	FAILED,

	/// <summary>
	/// Confirmed on the blockchain
	/// </summary>
	CONFIRMED
}
