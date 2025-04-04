using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class TransferPeerPathModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the peer
	/// </summary>
	public string? Id { get; set; }

	public TransferPeerPathType? Type { get; set; }
}
