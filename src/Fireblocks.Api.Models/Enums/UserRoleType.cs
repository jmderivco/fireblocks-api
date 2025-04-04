using System.Runtime.Serialization;

namespace Fireblocks.Api.Enums;

public enum UserRoleType
{
	Owner = 1,
	Admin,

	[EnumMember(Value = "Non-Signing Admin")]
	NoneSigningAdmin,

	Signer,
	Approver,
	Editor,
	Viewer
}
