namespace Fireblocks.Api.Models.Responses;

public class CancelTransactionResponseModel : BaseResponseModel
{
	/// <summary>
	/// True if the cancellation succeeded
	/// </summary>
	public bool? Success { get; set; }
}
