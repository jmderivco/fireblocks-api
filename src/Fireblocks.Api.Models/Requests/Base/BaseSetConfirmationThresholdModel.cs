namespace Fireblocks.Api.Models.Requests;

public abstract class BaseSetConfirmationThresholdModel : BaseRequestModel
{
	/// <summary>
	/// The number of transaction's confirmations to be considered COMPLETED
	/// </summary>
	public int? NumOfConfirmations { get; set; }

	/// <summary>
	/// Unique transaction ID
	/// </summary>
	public string? Txid { get; set; }
}
