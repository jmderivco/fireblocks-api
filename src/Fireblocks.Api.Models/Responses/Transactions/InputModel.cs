namespace Fireblocks.Api.Models.Responses;

public class InputModel : BaseResponseModel
{
	/// <summary>
	/// txHash
	/// </summary>
	public string? TxHash { get; set; }

	/// <summary>
	/// vOut of the txHash
	/// </summary>
	public string? Index { get; set; }
}
