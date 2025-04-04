namespace Fireblocks.Api.Models.Responses;

public class RewardsInfoModel : BaseResponseModel
{
	/// <summary>
	/// The ALGO rewards acknowledged by the source account of the transaction
	/// </summary>
	public string? SrcRewards { get; set; }

	/// <summary>
	/// The ALGO rewards acknowledged by the destination account of the transaction
	/// </summary>
	public string? DestRewards { get; set; }
}
