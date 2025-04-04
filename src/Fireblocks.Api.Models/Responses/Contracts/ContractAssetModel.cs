using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class ContractAssetModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the contract wallet
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// The balance of the contract wallet
	/// </summary>
	public string? Balance { get; set; }

	/// <summary>
	/// Locked amount in the contract wallet
	/// </summary>
	public string? LockedAmount { get; set; }

	/// <summary>
	/// Status of the contract wallet
	/// </summary>
	public ConfigChangeRequestStatus? Status { get; set; }

	/// <summary>
	/// The time the contract wallet will be activated if case wallets activation is posponed according to the workspace definition
	/// </summary>
	public string? ActivationTime { get; set; }

	/// <summary>
	/// The address of the contract wallet
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// Destination tag (for XRP, used as memo for EOS/XLM) of the contract wallet
	/// </summary>
	public string? Tag { get; set; }
}
