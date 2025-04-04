namespace Fireblocks.Api.Models.Requests;

public class SetAutoFuelModel : BaseRequestModel
{
	/// <summary>
	/// Should be set to true if you wish to monitor this account's Ethereum address for incomming deposits
	/// </summary>
	public bool? AutoFuel { get; set; }
}
