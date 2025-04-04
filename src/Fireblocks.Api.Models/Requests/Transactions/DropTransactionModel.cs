using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests;

public class DropTransactionModel : BaseRequestModel
{
	/// <summary>
	/// [optional] The requested fee level of the dropping transaction (LOW / MEDIUM / HIGH)
	/// </summary>
	public FeeLevelType? FeeLevel { get; set; }
}
