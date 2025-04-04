namespace Fireblocks.Api.Models.Responses;

public class CreateAddressModel : BaseAddressModel
{
	/// <summary>
	/// The address_index in the derivation path of this address based on BIP44
	/// </summary>
	public long? Bip44AddressIndex { get; set; }
}
