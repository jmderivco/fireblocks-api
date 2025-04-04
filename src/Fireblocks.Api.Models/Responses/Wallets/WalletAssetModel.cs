namespace Fireblocks.Api.Models.Responses;

public class WalletAssetModel : BaseWalletAssetModel
{
	/// <summary>
	/// The balance of the wallet<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Balance { get; set; }

	/// <summary>
	/// Locked amount in the wallet<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? LockedAmount { get; set; }
}
