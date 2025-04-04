namespace Fireblocks.Api.Models.Requests;

public abstract class BaseFiatFundModel : BaseRequestModel
{
	/// <summary>
	/// The reqested amount
	/// </summary>
	public string? Amount { get; set; }
}
