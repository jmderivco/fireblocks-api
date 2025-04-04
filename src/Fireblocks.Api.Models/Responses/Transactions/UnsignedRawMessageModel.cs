namespace Fireblocks.Api.Models.Responses;

public class UnsignedRawMessageModel : BaseResponseModel
{
	/// <summary>
	/// The message to be signed in hex format encoding
	/// </summary>
	public string? Content { get; set; }

	/// <summary>
	/// [optional] BIP44 address_index path level
	/// </summary>
	public long? Bip44AddressIndex { get; set; }

	/// <summary>
	/// [optional] BIP44 change path level
	/// </summary>
	public long? Bip44Change { get; set; }

	/// <summary>
	/// [optional] Should be passed only if asset and source were not specified
	/// </summary>
	public IEnumerable<long>? DerivationPath { get; set; }
}
