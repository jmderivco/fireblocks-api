using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class CreateTransactionResponseModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the transaction
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Status of the transaction
	/// </summary>
	public TransactionStatus? Status { get; set; }
}
