namespace Fireblocks.Api.Models.Responses;

public class EstimatedTransactionFeeResponseModel : BaseResponseModel
{
	/// <summary>
	/// Transactions with this fee will probably take longer to be mined
	/// </summary>
	public TransactionFeeModel? Low { get; set; }

	/// <summary>
	/// Average transactions fee
	/// </summary>
	public TransactionFeeModel? Medium { get; set; }

	/// <summary>
	/// Transactions with this fee should be mined the fastest
	/// </summary>
	public TransactionFeeModel? High { get; set; }
}
