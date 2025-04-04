namespace Fireblocks.Api.Models.Responses;

public class VaultAccountAssetAddressModel : CreateVaultAssetModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? AssetId { get; set; }

	/// <summary>
	/// Description of the address
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// Address type
	/// </summary>
	public string? Type { get; set; }

	/// <summary>
	/// The change address for BTC transactions
	/// </summary>
	public string? Change { get; set; }

	/// <summary>
	/// [optional] The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }

	/// <summary>
	/// [optional] The address_index, addressFormat, and enterpriseAddress in the derivation path of this address based on BIP44
	/// </summary>
	public long? Bip44AddressIndex { get; set; }
}
