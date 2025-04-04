namespace Fireblocks.Api.Models.Responses;

public class VaultAccountModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the Vault Account
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Vault Account
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Specifies whether this vault account is visible in the web console or not
	/// </summary>
	public bool? HiddenOnUI { get; set; }

	/// <summary>
	/// [optional] The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }

	/// <summary>
	/// Specifies whether this account's Ethereum address is auto fueled by the Gas Station or not
	/// </summary>
	public bool? AutoFuel { get; set; }

	/// <summary>
	/// List of assets under this Vault Account
	/// </summary>
	public IEnumerable<VaultAssetModel>? Assets { get; set; }
}
