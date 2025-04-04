namespace Fireblocks.Api.Models.Responses;

public class VaultAccountsPagedModel : BaseResponseModel
{
	/// <summary>
	/// List of vault account objects
	/// </summary>
	public IEnumerable<VaultAccountModel>? Accounts { get; set; }

	public Paging? Paging { get; set; }

	/// <summary>
	/// URL string of the request for the previous page
	/// </summary>
	public string? PreviousUrl { get; set; }

	/// <summary>
	/// URL string of the request for the next page
	/// </summary>
	public string? NextUrl { get; set; }
}
