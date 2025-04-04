namespace Fireblocks.Api.Models.Responses;

public class ChannelModel : BaseResponseModel
{
	/// <summary>
	/// 8 characters ID of the channel
	/// </summary>
	public string? NetworkId { get; set; }

	/// <summary>
	/// The name of the channel
	/// </summary>
	public string? Name { get; set; }
}
