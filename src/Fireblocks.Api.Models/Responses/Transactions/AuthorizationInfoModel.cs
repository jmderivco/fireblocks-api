using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class AuthorizationInfoModel : BaseResponseModel
{
	/// <summary>
	/// Set to "true" if the intiator of the transaction can be one of the approvers
	/// </summary>
	public bool? AllowOperatorAsAuthorizer { get; set; }

	/// <summary>
	/// "AND" or "OR", this is the logic that is applied between the different authorization groups listed below
	/// </summary>
	public LogicType Logic { get; set; }

	/// <summary>
	/// The list of authorization groups and users that are required to approve this transaction<br/>
	/// The logic applied between the different groups is the “logic” field above<br/>
	/// Each element in the response is the user ID (the can found see via the users endpoint) and their ApprovalStatus
	/// </summary>
	public IEnumerable<AuthorizationGroupModel>? Groups { get; set; }
}
