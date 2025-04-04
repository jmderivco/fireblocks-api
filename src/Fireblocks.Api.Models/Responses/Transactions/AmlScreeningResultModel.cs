namespace Fireblocks.Api.Models.Responses;

public class AmlScreeningResultModel : BaseResponseModel
{
	/// <summary>
	/// The AML service provider
	/// </summary>
	public string? Provider { get; set; }

	/// <summary>
	/// The response of the AML service provider
	/// </summary>
	public string? Payload { get; set; }
}
