using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests;

public class ExchangeInternalTransferModel : BaseRequestModel
{
	/// <summary>
	/// The type of the source trading account
	/// </summary>
	public TradingAccountType? SourceType { get; set; }

	/// <summary>
	/// The type of the source trading account
	/// </summary>
	public TradingAccountType? DestType { get; set; }

	/// <summary>
	/// The asset you wish to transfer
	/// </summary>
	public string? Asset { get; set; }

	/// <summary>
	/// The amount to transfer
	/// </summary>
	public string? Amount { get; set; }
}
