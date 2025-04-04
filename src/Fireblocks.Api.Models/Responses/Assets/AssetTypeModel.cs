using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class AssetTypeModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// The name of the asset
	/// </summary>
	public string? Name { get; set; }

	public AssetType? Type { get; set; }

	/// <summary>
	/// Contract address for ERC-20 smart contracts
	/// </summary>
	public string? ContractAddress { get; set; }

	/// <summary>
	/// The name of the native asset
	/// </summary>
	public string? NativeAsset { get; set; }

	/// <summary>
	/// The number of digits after the decimal point
	/// </summary>
	public decimal? Decimals { get; set; }
}
