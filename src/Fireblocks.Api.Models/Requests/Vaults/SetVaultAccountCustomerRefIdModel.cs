namespace Fireblocks.Api.Models.Requests;

public class SetVaultAccountCustomerRefIdModel : BaseRequestModel
{
	/// <summary>
	/// The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }
}
