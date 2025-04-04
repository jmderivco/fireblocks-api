namespace Fireblocks.Api.Models.Requests.Params;

public class GetVaultAssetsBalanceParams : BaseQueryParam
{
	/// <summary>
	/// Filter the response based on this account name prefix
	/// </summary>
	public string? accountNamePrefix { get; set; }

	/// <summary>
	/// Filter the response based on this account name prefix
	/// </summary>
	public string? accountNameSuffix { get; set; }
}
