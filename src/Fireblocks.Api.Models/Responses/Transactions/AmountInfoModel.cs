namespace Fireblocks.Api.Models.Responses;

public class AmountInfoModel : BaseResponseModel
{
	/// <summary>
	/// If the transfer is a withdrawal from an exchange, the actual amount that was requested to be transferred<br/>
	/// Otherwise, it is the requested amount<br/>
	/// This value will always be equal to the amount (number) parameter of TransactionDetails
	/// </summary>
	public string? Amount { get; set; }

	/// <summary>
	/// The amount requested by the user
	/// </summary>
	public string? RequestedAmount { get; set; }

	/// <summary>
	/// The net amount of the transaction, after fee deduction
	/// </summary>
	public string? NetAmount { get; set; }

	/// <summary>
	/// The USD value of the requested amount
	/// </summary>
	public string? AmountUSD { get; set; }
}
