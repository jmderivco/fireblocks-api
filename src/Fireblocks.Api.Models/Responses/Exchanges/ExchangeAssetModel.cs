namespace Fireblocks.Api.Models.Responses;

public class ExchangeAssetModel : BaseResponseModel
{
	/// <summary>
	/// he ID of the exchange account to return
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// The total balance of the asset in the exchange account<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Total { get; set; }

	/// <summary>
	/// The balance that can be withdrawan from the exchange account or moved to a different account<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Available { get; set; }

	/// <summary>
	/// Locked amount in the account<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? LockedAmount { get; set; }
}
