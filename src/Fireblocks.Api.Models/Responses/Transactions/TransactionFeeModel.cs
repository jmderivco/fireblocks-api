namespace Fireblocks.Api.Models.Responses;

public class TransactionFeeModel : BaseFeeModel
{
	/// <summary>
	/// [optional] For Ethereum assets (ETH and Tokens), the limit for how much can be used
	/// </summary>
	public string? GasLimit { get; set; }
}
