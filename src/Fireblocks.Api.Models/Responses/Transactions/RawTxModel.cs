namespace Fireblocks.Api.Models.Responses;

public class RawTxModel : BaseResponseModel
{
	/// <summary>
	/// Hex-encoded details of a transaction sent to the blockchain
	/// </summary>
	public string? RawTx { get; set; }

	/// <summary>
	/// Location of the encryption key within the customer’s HD Wallet URL used to sign this transaction
	/// </summary>
	public IEnumerable<long>? KeyDerivationPath { get; set; }
}
