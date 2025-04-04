namespace Fireblocks.Api.Models.Responses;

public class DestinationsResponseModel : BaseResponseModel
{
	/// <summary>
	/// The amount to be sent to this destination
	/// </summary>
	public string? Amount { get; set; }

	/// <summary>
	/// Destination of the transaction
	/// </summary>
	public TransferPeerPathResponseModel? Destination { get; set; }

	/// <summary>
	/// The USD value of the requested amount
	/// </summary>
	public decimal? AmountUSD { get; set; }

	/// <summary>
	/// Address where the asset were transfered
	/// </summary>
	public string? DestinationAddress { get; set; }

	/// <summary>
	/// Description of the address
	/// </summary>
	public string? DestinationAddressDescription { get; set; }

	/// <summary>
	/// The result of the AML screening
	/// </summary>
	public AmlScreeningResultModel? AmlScreeningResult { get; set; }

	/// <summary>
	/// The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }
}
