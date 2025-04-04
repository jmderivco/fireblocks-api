namespace Fireblocks.Api.Models.Responses;

public class FiatAssetModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// The balance of the asset<br/>
	/// Values are returned according to balance decimal precision
	/// </summary>
	public string? Balance { get; set; }
}
