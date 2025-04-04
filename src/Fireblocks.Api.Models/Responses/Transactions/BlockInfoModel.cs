namespace Fireblocks.Api.Models.Responses;

public class BlockInfoModel : BaseResponseModel
{
	/// <summary>
	/// The height (number) of the block the transaction was mined in
	/// </summary>
	public string? BlockHeight { get; set; }

	/// <summary>
	/// The hash of the block the transaction was mined in
	/// </summary>
	public string? BlockHash { get; set; }
}
