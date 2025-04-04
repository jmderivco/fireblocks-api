namespace Fireblocks.Api.Models.Requests;

public abstract class BaseSetCustomerRefIdModel : BaseRequestModel
{
	/// <summary>
	/// The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }
}
