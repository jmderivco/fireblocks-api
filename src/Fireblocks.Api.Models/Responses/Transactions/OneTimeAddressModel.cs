namespace Fireblocks.Api.Models.Responses;

public class OneTimeAddressModel : BaseResponseModel
{
	/// <summary>
	/// Transfer destination address
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// Transfer destination tag for Ripple<br/>
	/// memo for EOS/XLM<br/>
	/// for the fiat providers (Signet by Signature, SEN by Silvergate, BLINC by BCB Group), it is the Bank Transfer Description
	/// </summary>
	public string? Tag { get; set; }
}
