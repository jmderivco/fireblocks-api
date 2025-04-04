namespace Fireblocks.Api.Models.Responses;

public class ExternalWalletModel : BaseWalletModel
{
	/// <summary>
	/// Array of the assets available in the exteral wallet
	/// </summary>
	public IEnumerable<ExternalWalletAssetModel>? Assets { get; set; }
}
