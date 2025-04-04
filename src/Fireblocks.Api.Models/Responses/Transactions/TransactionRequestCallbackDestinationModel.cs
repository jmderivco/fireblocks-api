using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class TransactionRequestCallbackDestinationModel : BaseResponseModel
{
	/// <summary>
	/// The amount transfered to this destination as a number
	/// </summary>
	public decimal? AmountNative { get; set; }

	/// <summary>
	/// The amount transfered to this destination in a string representation
	/// </summary>
	public string? AmountNativeStr { get; set; }

	/// <summary>
	/// The USD value transfered to this destination
	/// </summary>
	public decimal? AmountUSD { get; set; }

	public DestinationAddressType? DstAddressType { get; set; }

	/// <summary>
	/// The ID of the destination
	/// </summary>
	public string? DstId { get; set; }

	/// <summary>
	/// The name of the destination
	/// </summary>
	public string? DstName { get; set; }

	// TODO: Check 'DstSubType' return value to see if it's a string or an enum
	/// <summary>
	/// The specific exchnage, fiat account or unmanaged wallet (either INTERNAL / EXTERNAL)
	/// </summary>
	public string? DstSubType { get; set; }

	/// <summary>
	/// The destination of the transaction (VAULT, EXCHANGE or UNMANAGED)
	/// </summary>
	public DestinationType? DstType { get; set; }

	/// <summary>
	/// The address of this specific destination
	/// </summary>
	public string? DisplayDstAddress { get; set; }
}
