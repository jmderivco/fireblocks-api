using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class UserModel : BaseResponseModel
{
	/// <summary>
	/// User ID on the Fireblocks platform
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// First name
	/// </summary>
	public string? FirstName { get; set; }

	/// <summary>
	/// Last name
	/// </summary>
	public string? LastName { get; set; }

	/// <summary>
	/// The role of the user in the workspace, one of the options as described here<br/>
	/// https://support.fireblocks.io/hc/en-us/articles/360012832959-User-Roles
	/// </summary>
	public UserRoleType? Role { get; set; }

	/// <summary>
	/// The email of the user
	/// </summary>
	public string? Email { get; set; }

	/// <summary>
	/// The status of the user in the workspace
	/// </summary>
	public bool? Enabled { get; set; }
}
