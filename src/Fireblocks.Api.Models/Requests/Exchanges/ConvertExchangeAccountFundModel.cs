namespace Fireblocks.Api.Models.Requests;

public class ConvertExchangeAccountFundModel : BaseRequestModel
{
	/// <summary>
	/// The name of the source asset<br/>
	/// This must be in a currency that is supported for conversions in the selected exchange type that corresponds to your exchange ID
	/// </summary>
	public string? SrcAsset { get; set; }

	/// <summary>
	/// The name of the destination asset<br/>
	/// This must be in a currency that is supported for conversions in the selected exchange type that corresponds to your exchange ID
	/// </summary>
	public string? DestAsset { get; set; }

	/// <summary>
	/// The amount to transfer (in the currency of the source asset)
	/// </summary>
	public decimal? Amount { get; set; }
}
