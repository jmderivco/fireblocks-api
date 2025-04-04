namespace Fireblocks.Api.Models.Responses;

public class VaultAssetModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// The total wallet balance<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Total { get; set; }

	/// <summary>
	/// Funds available for transfer. Equals the blockchain balance minus any locked amount<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Available { get; set; }

	/// <summary>
	/// The cumulative balance of all transactions pending to be cleared<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Pending { get; set; }

	/// <summary>
	/// Staked funds, returned only for DOT<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Staked { get; set; }

	/// <summary>
	/// Frozen by the AML policy in your workspace<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Frozen { get; set; }

	/// <summary>
	/// Funds in outgoing transactions that are not yet published to the network<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? LockedAmount { get; set; }

	/// <summary>
	/// The maximum BIP44 index used in deriving addresses for this wallet
	/// </summary>
	public long? MaxBip44AddressIndexUsed { get; set; }

	/// <summary>
	/// The maximum BIP44 index used in deriving change addresses for this wallet
	/// </summary>
	public long? MaxBip44ChangeAddressIndexUsed { get; set; }

	/// <summary>
	/// The height (number) of the block of the balance
	/// </summary>
	public long? BlockHeight { get; set; }

	/// <summary>
	/// The hash of the block of the balance
	/// </summary>
	public string? BlockHash { get; set; }
}
