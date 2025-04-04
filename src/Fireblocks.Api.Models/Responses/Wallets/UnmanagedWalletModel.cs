namespace Fireblocks.Api.Models.Responses;

public class UnmanagedWalletModel : BaseWalletModel
{
	/// <summary>
	/// Array of the assets available in the unmanaged wallet
	/// </summary>
	public IEnumerable<WalletAssetModel>? Assets { get; set; }
}
