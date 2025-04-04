using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests;

public class EstimateTransactionFeeModel : BaseRequestModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? AssetId { get; set; }

	/// <summary>
	/// The requested amount to transfer
	/// </summary>
	public string? Amount { get; set; }

	/// <summary>
	/// The source of the estimated transaction
	/// </summary>
	public TransferPeerPathType? Source { get; set; }

	/// <summary>
	/// The destination of the estimated transaction<br/>
	/// For some blockchains it can affect the transaction fee.
	/// </summary>
	public DestinationTransferPeerPathType? Destination { get; set; }

	/// <summary>
	/// [optional] Transaction operation type, the default is "TRANSFER"
	/// </summary>
	public TransactionOperationType? Operation { get; set; }
}
