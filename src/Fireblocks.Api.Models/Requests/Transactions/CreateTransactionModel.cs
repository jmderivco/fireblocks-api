using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests;

public class CreateTransactionModel : BaseRequestModel
{
	/// <summary>
	/// The ID of the asset
	/// </summary>
	public string? AssetId { get; set; }

	/// <summary>
	/// The source account of the transaction
	/// </summary>
	public TransferPeerPathType? Source { get; set; }

	/// <summary>
	/// The destination of the transaction
	/// </summary>
	public DestinationTransferPeerPathType? Destination { get; set; }

	/// <summary>
	/// For UTXO based assets, you can send a single transaction to multiple destinations which should be specified using this field
	/// </summary>
	public IEnumerable<TransactionDestinationType>? Destinations { get; set; }

	/// <summary>
	/// The requested amount to transfer
	/// </summary>
	public string? Amount { get; set; }

	/// <summary>
	/// False by default, if set to true the network fee will be deducted from the requested amount
	/// </summary>
	public bool? TreatAsGrossAmount { get; set; }

	/// <summary>
	/// [optional] For UTXO assets, the fee per bytes in the asset's smallest unit (Satoshi, Latoshi, etc.)
	/// </summary>
	public string? Fee { get; set; }

	/// <summary>
	/// [optional] For ETH-based assets only this will be used instead of the fee property, value is in Gwei
	/// </summary>
	public string? GasPrice { get; set; }

	/// <summary>
	/// [optional] For ETH-based assets only
	/// </summary>
	public string? GasLimit { get; set; }

	/// <summary>
	/// [optional] The transaction blockchain fee<br/>
	/// For Ethereum, you can't pass gasPrice, gasLimit and networkFee all together
	/// </summary>
	public string? NetworkFee { get; set; }

	/// <summary>
	/// [optional] The priority fee of Ethereum transaction according to EIP-1559
	/// </summary>
	public string? PriorityFee { get; set; }

	/// <summary>
	/// [optional] LOW / MEDIUM / HIGH - Defines the blockchain fee level which will be payed for the transaction<br/>
	/// Only for Ethereum and UTXO blockchains
	/// </summary>
	public FeeLevelType? FeeLevel { get; set; }

	/// <summary>
	/// [optional] The maximum fee (gas price or fee per byte) that should be payed for the transaction<br/>
	/// In case the current value of the requested fee level is higher than this requested maximum fee
	/// </summary>
	public string? MaxFee { get; set; }

	/// <summary>
	/// [optional] False by default, if set to true and the current MEDIUM fee level is higher than the one specified in the transaction, the transction will fail to avoid getting stuck with 0 confirmations
	/// </summary>
	public bool? FailOnLowFee { get; set; }

	/// <summary>
	/// For "DOT" transactions only, "false" by default, if set to "true" Fireblocks will allow emptying the DOT wallet
	/// </summary>
	public bool? ForceSweep { get; set; }

	/// <summary>
	/// [optional] Note to be added to the transaction history
	/// </summary>
	public string? Note { get; set; }

	/// <summary>
	/// [optional] Transaction operation type, the default is "TRANSFER"
	/// </summary>
	public TransactionOperationType? Operation { get; set; }

	/// <summary>
	/// [optional] The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }

	/// <summary>
	/// [optional] For Ethereum blockchain transactions, the hash of the stuck transaction to be replaced (RBF)
	/// </summary>
	public string? ReplaceTxByHash { get; set; }

	/// <summary>
	/// [optional] Unique transaction ID provided by the user. Future transactions with same ID will be rejected
	/// </summary>
	public string? ExternalTxId { get; set; }

	/// <summary>
	/// [optional] Use for protocol / operation specific parameters<br/>
	/// For raw signing, pass rawMessageData field<br/>
	/// For contract calls, pass contractCallData(See here for more details on Smart Contract API and contract calls)<br/>
	/// For UTXO based blockchains inputs selectios pass inputsSelection following this structure. The inputs can be retrieved from Retrieve Unspent Inputs
	/// </summary>
	public object? ExtraParameters { get; set; }
}
