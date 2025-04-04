namespace Fireblocks.Api.Models.Responses;

public class AddressStatusModel : BaseResponseModel
{
	/// <summary>
	/// Returns "false" if the address is in a wrong format
	/// </summary>
	public bool? IsValid { get; set; }

	/// <summary>
	/// Returns "false" if the address doesn't have enough balance or wasn't activate
	/// </summary>
	public bool? IsActive { get; set; }

	/// <summary>
	/// Returns "true" if the address requires tag when used as a transaction destination
	/// </summary>
	public bool? RequiresTag { get; set; }
}
