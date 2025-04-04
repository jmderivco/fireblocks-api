using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Responses;

public class TransactionDetailsModel : BaseResponseModel
{
	/// <summary>
	/// ID of the transaction
	/// </summary>
	public string? Id { get; set; }

	/// <summary>
	/// Transaction asset
	/// </summary>
	public string? AssetId { get; set; }

	/// <summary>
	/// Source of the transaction
	/// </summary>
	public TransferPeerPathResponseModel? Source { get; set; }

	/// <summary>
	/// Destination of the transaction
	/// </summary>
	public TransferPeerPathResponseModel? Destination { get; set; }

	/// <summary>
	/// The amount requested by the user
	/// </summary>
	public decimal? RequestedAmount { get; set; }

	/// <summary>
	/// Details of the transaction's amount in string format
	/// </summary>
	public AmountInfoModel? AmountInfo { get; set; }

	/// <summary>
	/// Details of the transaction's fee in string format
	/// </summary>
	public FeeInfoModel? FeeInfo { get; set; }

	/// <summary>
	/// If the transfer is a withdrawal from an exchange, the actual amount that was requested to be transferred<br/>
	/// Otherwise, the requested amount
	/// </summary>
	public decimal? Amount { get; set; }

	/// <summary>
	/// The net amount of the transaction, after fee deduction
	/// </summary>
	public decimal? NetAmount { get; set; }

	/// <summary>
	/// The USD value of the requested amount
	/// </summary>
	public decimal? AmountUSD { get; set; }

	/// <summary>
	/// The total fee deducted by the exchange from the actual requested amount (serviceFee = amount - netAmount)
	/// </summary>
	public decimal? ServiceFee { get; set; }

	/// <summary>
	/// For outgoing transactions, if true, the network fee is deducted from the requested amount
	/// </summary>
	public bool? TreatAsGrossAmount { get; set; }

	/// <summary>
	/// The fee paid to the network
	/// </summary>
	public decimal? NetworkFee { get; set; }

	/// <summary>
	/// Unix timestamp
	/// </summary>
	public long? CreatedAt { get; set; }

	/// <summary>
	/// Unix timestamp
	/// </summary>
	public long? LastUpdated { get; set; }

	/// <summary>
	/// The current status of the transaction
	/// </summary>
	public TransactionStatus? Status { get; set; }

	/// <summary>
	/// Blockchain hash of the transaction
	/// </summary>
	public string? TxHash { get; set; }

	/// <summary>
	/// [optional] For UTXO based assets this is the vOut<br/>
	/// for Ethereum based, this is the index of the event of the contract call
	/// </summary>
	public int Index { get; set; }

	/// <summary>
	/// More detailed status of the transaction
	/// </summary>
	public TransactionSubStatus? SubStatus { get; set; }

	/// <summary>
	/// For account based assets only, the source address of the transaction
	/// </summary>
	public string? SourceAddress { get; set; }

	/// <summary>
	/// Address where the asset were transfered
	/// </summary>
	public string? DestinationAddress { get; set; }

	/// <summary>
	/// Description of the address
	/// </summary>
	public string? DestinationAddressDescription { get; set; }

	/// <summary>
	/// Destination tag for XRP, used as memo for EOS/XLM<br/>
	/// or Bank Transfer Description for the fiat providers: Signet (by Signature), SEN (by Silvergate)<br/>
	/// or BLINC (by BCB Group)
	/// </summary>
	public string? DestinationTag { get; set; }

	/// <summary>
	/// Signers of the transaction
	/// </summary>
	public IEnumerable<string>? SignedBy { get; set; }

	/// <summary>
	/// Initiator of the transaction
	/// </summary>
	public string? CreatedBy { get; set; }

	/// <summary>
	/// User ID of the user that rejected the transaction (in case it was rejected)
	/// </summary>
	public string? RejectedBy { get; set; }

	public DestinationAddressType? AddressType { get; set; }

	/// <summary>
	/// Custome note of the transaction
	/// </summary>
	public string? Note { get; set; }

	/// <summary>
	/// If the transaction originated from an exchange, this is the exchange tx ID
	/// </summary>
	public string? ExchangeTxId { get; set; }

	/// <summary>
	/// The asset which was taken to pay the fee (ETH for ERC-20 tokens, BTC for Tether Omni)
	/// </summary>
	public string? FeeCurrency { get; set; }

	/// <summary>
	/// Default operation is "TRANSFER"
	/// </summary>
	public TransactionOperationType? Operation { get; set; }

	/// <summary>
	/// The result of the AML screening
	/// </summary>
	public AmlScreeningResultModel? AmlScreeningResult { get; set; }

	/// <summary>
	/// The ID for AML providers to associate the owner of funds with transactions
	/// </summary>
	public string? CustomerRefId { get; set; }

	/// <summary>
	/// The number of confirmations of the transaction<br/>
	/// The number will increase until the transaction will be considered completed according to the confirmation policy
	/// </summary>
	public int? NumOfConfirmations { get; set; }

	/// <summary>
	/// Transaction on the Fireblocks platform can aggregate several blockchain transactions<br/>
	/// in such a case these records specify all the transactions that took place on the blockchain
	/// </summary>
	public IEnumerable<NetworkRecordModel>? NetworkRecords { get; set; }

	/// <summary>
	/// In case of an RBF transaction, the hash of the dropped transaction
	/// </summary>
	public string? ReplacedTxHash { get; set; }

	/// <summary>
	/// Unique transaction ID provided by the user
	/// </summary>
	public string? ExternalTxId { get; set; }

	/// <summary>
	/// For UTXO based assets, all outputs specified here
	/// </summary>
	public IEnumerable<DestinationsResponseModel>? Destinations { get; set; }

	/// <summary>
	/// The information of the block that this transaction was mined in, the blocks's hash and height
	/// </summary>
	public BlockInfoModel? BlockInfo { get; set; }

	/// <summary>
	/// This field is relevant only for ALGO transactions<br/>
	/// Both srcRewrds and destRewards will appear only for Vault to Vault transactions<br/>
	/// otherwise you will receive only the Fireblocks' side of the transaction
	/// </summary>
	public RewardsInfoModel? RewardsInfo { get; set; }

	/// <summary>
	/// The information about your Transaction Authorization Policy (TAP)<br/>
	/// For more information about the TAP, refer to this section in the Help Center<br/>
	/// https://support.fireblocks.io/hc/en-us/sections/4416991348626-Transaction-Authorization-Policy
	/// </summary>
	public AuthorizationInfoModel? AuthorizationInfo { get; set; }

	/// <summary>
	/// A list of signed messages returned for raw signing
	/// </summary>
	public IEnumerable<SignedMessageModel>? SignedMessages { get; set; }

	/// <summary>
	/// Protocol / operation specific parameters (JSON object)
	/// </summary>
	public string? ExtraParameters { get; set; }
}
