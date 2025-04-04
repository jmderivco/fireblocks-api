namespace Fireblocks.Api.Models.Responses;

public class TransactionRequestDestinationModel : BaseResponseModel
{
	/// <summary>
	/// The amount to be sent to this destination
	/// </summary>
	public string? Amount { get; set; }

	/// <summary>
	/// The specific destination
	/// </summary>
	public DestinationTransferPeerPathModel? Destination { get; set; }
}
