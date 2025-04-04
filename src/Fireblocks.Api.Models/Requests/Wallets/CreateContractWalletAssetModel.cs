namespace Fireblocks.Api.Models.Requests;

public class CreateContractWalletAssetModel : BaseRequestModel
{
	/// <summary>
	/// The wallet's address (should match the assetId)<br/>
	/// For example, if the asset is ETH, the address should be the contract address on the Ethereum blockchain<br/>
	/// For EOS wallets, it is the account name
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// For XRP, the destination tag<br/>
	/// for EOS/XLM, the memo<br/>
	/// for the fiat providers (Signet by Signature, SEN by Silvergate, BLINC by BCB Group), the Bank Transfer description
	/// </summary>
	public string? Tag { get; set; }
}
