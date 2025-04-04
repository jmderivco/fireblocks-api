namespace Fireblocks.Api.Models.Responses;

public class NetworkConnectionModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the Network Connection
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Local channel ID
	/// </summary>
	public ChannelModel? LocalChannel { get; set; }

	/// <summary>
	/// Remote channel ID
	/// </summary>
	public ChannelModel? RemoteChannel { get; set; }
}
