namespace Fireblocks.Api.Models.Requests;

public class SetAddressDescriptionModel : BaseRequestModel
{
	/// <summary>
	/// [optional] Description of the new address
	/// </summary>
	public string? Description { get; set; }
}
