namespace Fireblocks.Api.Models.Requests.Params;

public class RetrieveNetworkFeeParams : BaseQueryParam
{
	/// <summary>
	/// The asset for which you wish to retrieve the network fees
	/// </summary>
	public string? assetId { get; set; }
}
