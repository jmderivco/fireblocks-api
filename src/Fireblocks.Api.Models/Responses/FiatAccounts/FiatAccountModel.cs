using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class FiatAccountModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the account
	/// </summary>
	public string? Id { get; set; }

	public FiatAccountType? Type { get; set; }

	/// <summary>
	/// Display name of the fiat account
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// The address of the account
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// Array of the assets under the account
	/// </summary>
	public IEnumerable<FiatAssetModel>? Assets { get; set; }
}
