namespace Fireblocks.Api.Models.Responses;

public class SetConfirmationsThresholdResponseModel : BaseResponseModel
{
	public bool? Success { get; set; }

	/// <summary>
	/// TxIds of the transactions
	/// </summary>
	public IEnumerable<string>? Transactions { get; set; }
}
