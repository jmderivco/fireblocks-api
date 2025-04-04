namespace Fireblocks.Api.Models.Responses;

public class AuthorizationGroupModel : BaseResponseModel
{
	/// <summary>
	/// The threshold of required approvers in this authorization group
	/// </summary>
	public int? Th { get; set; }

	/// <summary>
	/// The list of users that the threshold number is applied to for transaction approval<br/>
	/// Each user in the response is a "key:value" where the key is the user ID (the can found see via the users endpoint) and the value is the theirApprovalStatus
	/// </summary>
	public IEnumerable<IDictionary<string, string>>? Users { get; set; }
}
