using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public abstract class BaseWalletAssetModel : BaseResponseModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Status of the Wallet
	/// </summary>
	public ConfigChangeRequestStatus? Status { get; set; }

	/// <summary>
	/// The time the wallet will be activated in case wallets activation posponed according to workspace definition
	/// </summary>
	public string? ActivationTime { get; set; }

	/// <summary>
	/// The address of the wallet
	/// </summary>
	public string? Address { get; set; }

	/// <summary>
	/// Destination tag (for XRP, used as memo for EOS/XLM) of the wallet
	/// </summary>
	public string? Tag { get; set; }
}
