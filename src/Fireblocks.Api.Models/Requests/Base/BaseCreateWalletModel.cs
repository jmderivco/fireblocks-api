namespace Fireblocks.Api.Models.Requests;

public abstract class BaseCreateWalletModel : BaseRequestModel
{
	/// <summary>
	/// The wallet container's display name
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// [optional] The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }
}
