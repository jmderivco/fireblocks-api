namespace Fireblocks.Api.Models.Requests;

public class CreateContractWalletModel : BaseRequestModel
{
	/// <summary>
	/// The wallet's display name
	/// </summary>
	public string? Name { get; set; }
}
