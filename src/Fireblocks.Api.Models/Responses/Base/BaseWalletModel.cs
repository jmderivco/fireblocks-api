namespace Fireblocks.Api.Models.Responses;

public abstract class BaseWalletModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the Unmanaged Wallet
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Name of the Wallet Container
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// [optional] The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }
}
