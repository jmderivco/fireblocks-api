using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class SignedMessageModel : BaseResponseModel
{
	/// <summary>
	/// The message for signing (hex-formatted)
	/// </summary>
	public string? Content { get; set; }

	/// <summary>
	/// The algorithm that was used for signing, one of the SigningAlgorithms
	/// </summary>
	public SigningAlgorithm? Algorithm { get; set; }

	/// <summary>
	/// BIP32 derivation path of the signing key. E.g. [44,0,46,0,0]
	/// </summary>
	public IEnumerable<long>? DerivationPath { get; set; }

	/// <summary>
	/// The message signature
	/// </summary>
	public SignedMessageModelSignature? Signature { get; set; }

	/// <summary>
	/// Signature's public key that can be used for verification
	/// </summary>
	public string? PublicKey { get; set; }
}
