using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests.Params;

public class ListTransactionsParams : BaseQueryParam
{
	/// <summary>
	/// [optional] Unix timestamp in milliseconds<br/>
	/// Returns only transactions created before the specified date
	/// </summary>
	public long? before { get; set; }

	/// <summary>
	/// [optional] Unix timestamp in milliseconds<br/>
	/// Returns only transactions created after the specified date
	/// </summary>
	public long? after { get; set; }

	/// <summary>
	/// [optional] You can filter by one of the statuses
	/// </summary>
	public TransactionStatus? status { get; set; }

	/// <summary>
	/// [optional] The field to order the results by<br/>
	/// Available values : createdAt (default), lastUpdated
	/// </summary>
	public string? orderBy { get; set; }

	/// <summary>
	/// [optional] The source type of the transaction
	/// </summary>
	public TransactionSourceType? sourceType { get; set; }

	/// <summary>
	/// [optional] The source ID of the transaction
	/// </summary>
	public string? sourceId { get; set; }

	/// <summary>
	/// [optional] The destination type of the transaction
	/// </summary>
	public TransactionDestinationType? destType { get; set; }

	/// <summary>
	/// [optional] The destination ID of the transaction
	/// </summary>
	public string? destId { get; set; }

	/// <summary>
	/// [optional] A list of assets to filter by, seperated by commas
	/// </summary>
	public string? assets { get; set; }

	/// <summary>
	/// [optional] Returns only results with a specified txHash
	/// </summary>
	public string? txHash { get; set; }

	/// <summary>
	/// [optional] Limits the number of returned transactions<br/>
	/// If not provided, a defult of 200 will be returned. The maximum allowed limit is 500.
	/// </summary>
	public int? limit { get; set; }

	/// <summary>
	/// [optional] Possible values are ASC or DESC<br/>
	/// DESC is the default behavior for getting transaction from latests to the oldest.
	/// </summary>
	public SortType? sort { get; set; }
}
