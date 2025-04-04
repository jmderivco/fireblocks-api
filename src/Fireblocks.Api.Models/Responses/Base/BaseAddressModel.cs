namespace Fireblocks.Api.Models.Responses;

public abstract class BaseAddressModel : BaseResponseModel
{
	/// <summary>
	/// Address of the asset in a Vault Account<br/>
	/// for BTC/LTC the address is in Segwit (Bech32) format, cash address format for BCH
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// Legacy address format for BTC/LTC/BCH
	/// </summary>
	public string? LegacyAddress { get; set; }

	/// <summary>
	/// Destination tag for XRP, used as memo for EOS/XLM
	/// </summary>
	public string? Tag { get; set; }
}
