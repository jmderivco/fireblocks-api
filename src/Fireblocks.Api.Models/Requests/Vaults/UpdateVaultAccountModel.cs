namespace Fireblocks.Api.Models.Requests;

public class UpdateVaultAccountModel : BaseRequestModel
{
	/// <summary>
	/// The new name of the vault account
	/// </summary>
	public string? Name { get; set; }
}
