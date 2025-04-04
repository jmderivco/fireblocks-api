using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class PublicKeyModel : BaseResponseModel
{
	/// <summary>
	/// The requested public key
	/// </summary>
	public string? PublicKey { get; set; }

	public SigningAlgorithm? Algorithm { get; set; }

	/// <summary>
	/// For BIP32 derivation used to retrieve the public key
	/// </summary>
	public IEnumerable<long?>? DerivationPath { get; set; }
}
