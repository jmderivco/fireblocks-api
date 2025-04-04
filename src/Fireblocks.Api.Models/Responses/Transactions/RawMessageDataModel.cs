using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class RawMessageDataModel : BaseResponseModel
{
	/// <summary>
	/// The messages that should be signed
	/// </summary>
	public IEnumerable<UnsignedRawMessageModel>? Messages { get; set; }

	/// <summary>
	/// [optional] The algorithm which will be used to sign the transaction, one of the SigningAlgorithms
	/// </summary>
	public SigningAlgorithm? Algorithm { get; set; }
}
