namespace Fireblocks.Api.Models.Responses;

public class InputsSelectionModel : BaseResponseModel
{
	/// <summary>
	/// Inputs that should be used in the transaction
	/// </summary>
	public IEnumerable<InputModel>? InputsToSpend { get; set; }

	/// <summary>
	/// Inputs that shouldn't be used in the transaction
	/// </summary>
	public IEnumerable<InputModel>? InputsToExclude { get; set; }
}
