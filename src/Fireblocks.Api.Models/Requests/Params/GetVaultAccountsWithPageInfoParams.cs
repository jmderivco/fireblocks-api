using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests.Params;

public class GetVaultAccountsWithPageInfoParams : GetVaultAccountsParams
{
	/// <summary>
	/// Returns default values in DESC order. Available in ASC, DESC<br/>
	/// The results are ordered by the creation time of the vault account
	/// </summary>
	public SortType? orderBy { get; set; }

	/// <summary>
	/// Returns the maximum number of vault accounts in a single response<br/>
	/// The default value is 300 and maximum value is 500
	/// </summary>
	public int limit { get; set; } = 300;

	/// <summary>
	/// [optional] cursor string, if specified then we give the next results after this cursor
	/// </summary>
	public string? before { get; set; }

	/// <summary>
	/// [optional] cursor string, if specified then we give the next results before this cursor
	/// </summary>
	public string? after { get; set; }
}
