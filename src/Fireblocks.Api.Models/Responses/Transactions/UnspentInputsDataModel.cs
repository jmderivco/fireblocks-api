namespace Fireblocks.Api.Models.Responses;

public class UnspentInputsDataModel : BaseResponseModel
{
	/// <summary>
	/// An object containing the txHash and index of this input
	/// </summary>
	public InputModel? Input { get; set; }

	/// <summary>
	/// The destination address of this input
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// The amount of this input
	/// </summary>
	public string? Amount { get; set; }

	/// <summary>
	/// Number of confirmations for the transaction of this input
	/// </summary>
	public int? Confirmations { get; set; }

	/// <summary>
	/// The status is based on the status of the transaction
	/// </summary>
	public string? Status { get; set; }
}
