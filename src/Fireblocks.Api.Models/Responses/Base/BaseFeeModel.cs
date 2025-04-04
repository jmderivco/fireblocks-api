namespace Fireblocks.Api.Models.Responses;

public abstract class BaseFeeModel : BaseResponseModel
{
	/// <summary>
	/// [optional] For UTXOs
	/// </summary>
	public string? FeePerByte { get; set; }

	/// <summary>
	/// [optional] For Ethereum assets (ETH and Tokens)
	/// </summary>
	public string? GasPrice { get; set; }

	/// <summary>
	/// [optional] All other assets
	/// </summary>
	public string? NetworkFee { get; set; }

	/// <summary>
	/// [optional] Base Fee according to EIP-1559 (ETH assets)
	/// </summary>
	public string? BaseFee { get; set; }

	/// <summary>
	/// [optional] Priority Fee according to EIP-1559 (ETH assets)
	/// </summary>
	public string? PriorityFee { get; set; }
}
