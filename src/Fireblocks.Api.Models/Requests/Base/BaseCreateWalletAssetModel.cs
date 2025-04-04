namespace Fireblocks.Api.Models.Requests;

public abstract class BaseCreateWalletAssetModel : BaseRequestModel
{
	/// <summary>
	/// The wallet's address or, for EOS wallets, the account name
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// For XRP wallets, the destination tag<br/>
	/// for EOS/XLM, the memo<br/>
	/// for the fiat providers (Signet by Signature, SEN by Silvergate, BLINC by BCB Group), the Bank Transfer Description
	/// </summary>
	public string? Tag { get; set; }
}
