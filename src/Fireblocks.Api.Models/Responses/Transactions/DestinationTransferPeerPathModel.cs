using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class DestinationTransferPeerPathModel : BaseResponseModel
{
	/// <summary>
	/// The peer ID (not needed for ONE_TIME_ADDRESS)
	/// </summary>
	public string? Id { get; set; }

	public DestinationTransferPeerPathType? Type { get; set; }

	/// <summary>
	/// [optional] Destination address<br/>
	/// You will only be able to provide this parameter if the type is enabled for OneTimeAddress
	/// </summary>
	public OneTimeAddressModel? OneTimeAddress { get; set; }
}
