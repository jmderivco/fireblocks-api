namespace Fireblocks.Api.Models.Requests.Params;

public class GetPublicKeyInfoForVaultAccountParams : BaseQueryParam
{
	/// <summary>
	/// Whether the returned key should be in compressed format or not, false by default
	/// </summary>
	public bool? compressed { get; set; }
}
