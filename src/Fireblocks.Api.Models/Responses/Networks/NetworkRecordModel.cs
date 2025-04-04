using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class NetworkRecordModel : BaseResponseModel
{
	/// <summary>
	/// Source of the transaction
	/// </summary>
	public TransferPeerPathResponseModel? Source { get; set; }

	/// <summary>
	/// Destination of the transaction
	/// </summary>
	public TransferPeerPathResponseModel? Destination { get; set; }

	/// <summary>
	/// Blockchain hash of the transaction
	/// </summary>
	public string? TxHash { get; set; }

	/// <summary>
	/// The fee paid to the network
	/// </summary>
	public decimal? NetworkFee { get; set; }

	/// <summary>
	/// Transaction asset
	/// </summary>
	public string? AssetId { get; set; }

	/// <summary>
	/// The net amount of the transaction, after fee deduction
	/// </summary>
	public decimal? NetAmount { get; set; }

	/// <summary>
	/// Status of the blockchain transaction
	/// </summary>
	public NetworkStatus? Status { get; set; }

	/// <summary>
	/// Type of the operation
	/// </summary>
	public string? Type { get; set; }

	/// <summary>
	/// Destination address
	/// </summary>
	public string? DestinationAddress { get; set; }

	/// <summary>
	/// For account based assets only, the source address of the transaction
	/// </summary>
	public string? SourceAddress { get; set; }
}
