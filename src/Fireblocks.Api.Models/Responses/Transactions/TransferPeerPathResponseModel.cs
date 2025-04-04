using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class TransferPeerPathResponseModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the exchange account to return
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// The name of the exchange account
	/// </summary>
	public string? Name { get; set; }

	public TransferPeerPathResponseType? Type { get; set; }

	// TODO: Check 'SubType' return value to see if it's a string or an enum
	/// <summary>
	/// The specific exchange, fiat account or unmanaged wallet (either INTERNAL / EXTERNAL)
	/// </summary>
	public string? SubType { get; set; }
}
