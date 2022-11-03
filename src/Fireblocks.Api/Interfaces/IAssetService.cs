using Fireblocks.Api.Models.Responses;
using Refit;

namespace Fireblocks.Api.Interfaces;

public interface IAssetService
{
	/// <summary>
	/// Retrieve all Assets Supported by Fireblocks<br/>
	/// https://docs.fireblocks.com/api/?#supported-assets
	/// </summary>
	Task<ApiResponse<IEnumerable<AssetTypeModel>>> GetSupportedAssetsAsync();
}
