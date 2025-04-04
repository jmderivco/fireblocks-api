namespace Fireblocks.Api.Models.Requests;

public class GetMaxSpendableAmountModel : BaseRequestModel
{
	/// <summary>
	/// [optional] False by default<br/>
	/// The maximum number of inputs depends if the transaction will be signed by an automated co-signer server or on a mobile device
	/// </summary>
	public bool? ManualSigning { get; set; }
}
