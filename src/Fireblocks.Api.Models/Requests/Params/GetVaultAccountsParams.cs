namespace Fireblocks.Api.Models.Requests.Params;

public class GetVaultAccountsParams : BaseQueryParam
{
	/// <summary>
	/// Filter the response based on this account name prefix
	/// </summary>
	public string? namePrefix { get; set; }

	/// <summary>
	/// Filter the response based on this account name prefix
	/// </summary>
	public string? nameSuffix { get; set; }

	/// <summary>
	/// Returns assets with total balance more than the provided threshold
	/// </summary>
	public string? minAmountThreshold { get; set; }

	/// <summary>
	/// Returns only the wallets of the requested asset
	/// </summary>
	public string? assetId { get; set; }

	/// <summary>
	/// The maximum BIP44 index used in deriving addresses for this wallet
	/// </summary>
	public string? maxBip44AddressIndexUsed { get; set; }

	/// <summary>
	/// The maximum BIP44 index used in deriving change addresses for this wallet
	/// </summary>
	public string? maxBip44ChangeAddressIndexUsed { get; set; }
}
