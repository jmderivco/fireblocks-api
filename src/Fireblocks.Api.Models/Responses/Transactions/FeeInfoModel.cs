namespace Fireblocks.Api.Models.Responses;

public class FeeInfoModel : BaseResponseModel
{
	/// <summary>
	/// The fee paid to the network
	/// </summary>
	public string? NetworkFee { get; set; }

	/// <summary>
	/// The total fee deducted by the exchange from the actual requested amount (serviceFee = amount - netAmount)
	/// </summary>
	public string? ServiceFee { get; set; }
}
