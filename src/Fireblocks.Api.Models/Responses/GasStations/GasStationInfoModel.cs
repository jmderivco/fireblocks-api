namespace Fireblocks.Api.Models.Responses;

public class GasStationInfoModel : BaseResponseModel
{
	/// <summary>
	/// A dictionary of an asset and its balance in the Gas Station<br/>
	/// consists of a key (string representing the asset token name)<br/>
	/// and a value (actual balance for that asset for a customer’s gas station account)<br/>
	/// Values are returned according to balance decimal precision.
	/// </summary>
	public IDictionary<string, string>? Balance { get; set; }

	/// <summary>
	/// The settings of your Gas Station
	/// </summary>
	public GasStationConfigurationModel? Configuration { get; set; }
}
