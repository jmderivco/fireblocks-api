namespace Fireblocks.Api.Models.Responses;

public class UnmanagedContractModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the unmanaged contract wallet
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Name of the contract wallet container
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Array of the assets available in the unmanaged contract wallet
	/// </summary>
	public IEnumerable<ContractAssetModel>? Assets { get; set; }
}
