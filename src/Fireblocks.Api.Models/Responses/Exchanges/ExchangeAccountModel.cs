using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class ExchangeAccountModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the exchange account to return
	/// </summary>
	public string? Id { get; set; }
	public ExchangeType? Type { get; set; }

	/// <summary>
	/// Display name of the exchange account
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Status of the exchange account connection
	/// </summary>
	public ConfigChangeRequestStatus? Status { get; set; }

	/// <summary>
	/// Assets in the account
	/// </summary>
	public IEnumerable<ExchangeAssetModel>? Assets { get; set; }

	/// <summary>
	/// Trading accounts under this exchange account
	/// </summary>
	public IEnumerable<TradingAccountModel>? TradingAccounts { get; set; }

	/// <summary>
	/// True if the account is a subaccount in an exchange
	/// </summary>
	public bool? IsSubaccount { get; set; }

	/// <summary>
	/// The of the exchange main account
	/// </summary>
	public string? MainAccountId { get; set; }

	/// <summary>
	/// The internal account that is used for deposit or withdrawals of this exchange main or sub account
	/// </summary>
	public string? FundableAccountType { get; set; }
}
