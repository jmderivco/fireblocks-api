using System.Runtime.Serialization;

namespace Fireblocks.Api.Enums;

public enum TransactionSubStatus
{
	/// <summary>
	/// Not enough funds to fulfill the withdraw request
	/// </summary>
	INSUFFICIENT_FUNDS = 1,

	/// <summary>
	/// Attempt to withdraw an amount below the allowed minimum
	/// </summary>
	AMOUNT_TOO_SMALL,

	/// <summary>
	/// Asset is not supported
	/// </summary>
	UNSUPPORTED_ASSET,

	/// <summary>
	/// Third party (e.g. exchange) API missing permission
	/// </summary>
	UNAUTHORISED__MISSING_PERMISSION,

	/// <summary>
	/// Invalid transaction signature
	/// </summary>
	INVALID_SIGNATURE,

	/// <summary>
	/// Third party (e.g. exchange) API call invalid signature
	/// </summary>
	API_INVALID_SIGNATURE,

	/// <summary>
	/// Missing third party (e.g. exchange) credentials
	/// </summary>
	UNAUTHORISED__MISSING_CREDENTIALS,

	/// <summary>
	/// Attempt to initiate or approve a transaction by an unauthorised user
	/// </summary>
	UNAUTHORISED__USER,

	/// <summary>
	/// Unauthorised user's device
	/// </summary>
	UNAUTHORISED__DEVICE,

	/// <summary>
	/// Unmanaged wallet is disabled or does not exist
	/// </summary>
	INVALID_UNMANAGED_WALLET,

	/// <summary>
	/// Exchange account is disabled or does not exist
	/// </summary>
	INVALID_EXCHANGE_ACCOUNT,

	/// <summary>
	/// Not enough balance to fund the requested transaction
	/// </summary>
	INSUFFICIENT_FUNDS_FOR_FEE,

	/// <summary>
	/// Unsupported address format
	/// </summary>
	INVALID_ADDRESS,

	/// <summary>
	/// Transaction exceeds the exchange's withdraw limit
	/// </summary>
	WITHDRAW_LIMIT,

	/// <summary>
	/// Exceeded third party (e.g. exchange) API call limit
	/// </summary>
	API_CALL_LIMIT,

	/// <summary>
	/// Attempt to withdraw from an exchange to a non whitelisted address
	/// </summary>
	ADDRESS_NOT_WHITELISTED,

	/// <summary>
	/// The transaction request has timed out
	/// </summary>
	TIMEOUT,

	/// <summary>
	/// Network error
	/// </summary>
	CONNECTIVITY_ERROR,

	/// <summary>
	/// Received an internal error response from a third party service
	/// </summary>
	THIRD_PARTY_INTERNAL_ERROR,

	/// <summary>
	/// Transaction was canceled by a third party service
	/// </summary>
	CANCELLED_EXTERNALLY,

	/// <summary>
	/// Unrecognized third party response
	/// </summary>
	INVALID_THIRD_PARTY_RESPONSE,

	/// <summary>
	/// Vault wallet is not ready
	/// </summary>
	VAULT_WALLET_NOT_READY,

	/// <summary>
	/// Could not retrieve a deposit address from the exchange
	/// </summary>
	MISSING_DEPOSIT_ADDRESS,

	/// <summary>
	/// Transfering to non-whitelisted addresses is disabled in your workspace
	/// </summary>
	ONE_TIME_ADDRESS_DISABLED,

	/// <summary>
	/// Internal error while processing the transaction
	/// </summary>
	INTERNAL_ERROR,

	/// <summary>
	/// Unexpected error
	/// </summary>
	UNKNOWN_ERROR,

	/// <summary>
	/// No authorizer found to approve the operation or the only authorizer found is the initiator
	/// </summary>
	AUTHORIZER_NOT_FOUND,

	/// <summary>
	/// Some assets require a minimum of reserved funds being kept on the account
	/// </summary>
	INSUFFICIENT_RESERVED_FUNDING,

	/// <summary>
	/// Error while retrieving a deposit address from an exchange<br/>
	/// Please generate a deposit address for your exchange account
	/// </summary>
	MANUAL_DEPOSIT_ADDRESS_REQUIRED,

	/// <summary>
	/// Transaction fee is not in the allowed range
	/// </summary>
	INVALID_FEE,

	/// <summary>
	/// Attempt to execute an unsupported transaction Type
	/// </summary>
	ERROR_UNSUPPORTED_TRANSACTION_TYPE,

	/// <summary>
	/// Unsupported operation
	/// </summary>
	UNSUPPORTED_OPERATION,

	/// <summary>
	/// The transaction is pending approval by the 3rd party service (e.g exchange)
	/// </summary>
	[EnumMember(Value = "3RD_PARTY_PROCESSING")]
	THIRD_PARTY_PROCESSING,

	/// <summary>
	/// Pending Blockchain confirmations
	/// </summary>
	PENDING_BLOCKCHAIN_CONFIRMATIONS,

	/// <summary>
	/// Pending confirmation on the exchange
	/// </summary>
	[EnumMember(Value = "3RD_PARTY_CONFIRMING")]
	THIRD_PARTY_CONFIRMING,

	/// <summary>
	/// Confirmed on the blockchain
	/// </summary>
	CONFIRMED,

	/// <summary>
	/// Completed on the 3rd party service (e.g exchange)
	/// </summary>
	[EnumMember(Value = "3RD_PARTY_COMPLETED")]
	THIRD_PARTY_COMPLETED,

	/// <summary>
	/// The transaction was rejected by one of the signers
	/// </summary>
	REJECTED_BY_USER,

	/// <summary>
	/// The transaction was canceled via the Console or the API
	/// </summary>
	CANCELLED_BY_USER,

	/// <summary>
	/// Cancelled on the exchange
	/// </summary>
	[EnumMember(Value = "3RD_PARTY_CANCELLED")]
	THIRD_PARTY_CANCELLED,

	/// <summary>
	/// Rejected or not approved in time by user
	/// </summary>
	[EnumMember(Value = "3RD_PARTY_REJECTED")]
	THIRD_PARTY_REJECTED,

	/// <summary>
	/// Rejected on AML Screening
	/// </summary>
	REJECTED_AML_SCREENING,

	/// <summary>
	/// Transaction is blocked due to a policy rule
	/// </summary>
	BLOCKED_BY_POLICY,

	/// <summary>
	/// AML screening failed
	/// </summary>
	FAILED_AML_SCREENING,

	/// <summary>
	/// Only for Aggregated transactions. One or more of the associated transaction records failed
	/// </summary>
	PARTIALLY_FAILED,

	/// <summary>
	/// Transaction failed at the exchange
	/// </summary>
	[EnumMember(Value = "3RD_PARTY_FAILED")]
	THIRD_PARTY_FAILED,

	/// <summary>
	/// The transaction was replaced by another transaction with higher fee
	/// </summary>
	DROPPED_BY_BLOCKCHAIN,

	/// <summary>
	/// Transaction was rejected by the Blockchain due to too low fees, bad inputs or bad nonce
	/// </summary>
	REJECTED_BY_BLOCKCHAIN,

	/// <summary>
	/// Fee parameters are inconsistent or unknown
	/// </summary>
	INVALID_FEE_PARAMS,

	/// <summary>
	/// A tag or memo is required to send funds to a third party address, including all exchanges.
	/// </summary>
	MISSING_TAG_OR_MEMO,

	/// <summary>
	/// The transaction signing failed, resubmit the transaction to sign again
	/// </summary>
	SIGNING_ERROR,

	/// <summary>
	/// The transaction was rejected because the gas limit was set too low
	/// </summary>
	GAS_LIMIT_TOO_LOW,

	/// <summary>
	/// The transaction includes more inputs than the allowed limit (only for UTXO based blockchains)
	/// </summary>
	TOO_MANY_INPUTS,

	/// <summary>
	/// Gas price is currently above selected max fee
	/// </summary>
	MAX_FEE_EXCEEDED,

	/// <summary>
	/// Chosen fee is below current price
	/// </summary>
	ACTUAL_FEE_TOO_HIGH,

	/// <summary>
	/// Transaction data was not encoded properly
	/// </summary>
	INVALID_CONTRACT_CALL_DATA,

	/// <summary>
	/// Illegal nonce
	/// </summary>
	INVALID_NONCE_TOO_LOW,

	/// <summary>
	/// Illegal nonce
	/// </summary>
	INVALID_NONCE_TOO_HIGH,

	/// <summary>
	/// No matching nonce
	/// </summary>
	INVALID_NONCE_FOR_RBF,

	/// <summary>
	/// Current blockchain fee is higher than selected
	/// </summary>
	FAIL_ON_LOW_FEE,

	/// <summary>
	/// Too many unconfirmed transactions from this address
	/// </summary>
	TOO_LONG_MEMPOOL_CHAIN,

	/// <summary>
	/// Nonce already used
	/// </summary>
	TX_OUTDATED,

	/// <summary>
	/// MPC setup was not completed
	/// </summary>
	INCOMPLETE_USER_SETUP,

	/// <summary>
	/// Signer not found
	/// </summary>
	SIGNER_NOT_FOUND,

	/// <summary>
	/// Invalid Tag or Memo
	/// </summary>
	INVALID_TAG_OR_MEMO,

	/// <summary>
	/// Not enough BTC on legacy permanent address
	/// </summary>
	ZERO_BALANCE_IN_PERMANENT_ADDRESS,

	/// <summary>
	/// Insufficient funds for creating destination account
	/// </summary>
	NEED_MORE_TO_CREATE_DESTINATION,

	/// <summary>
	/// Account does not exist
	/// </summary>
	NON_EXISTING_ACCOUNT_NAME,

	/// <summary>
	/// Asset is not supported under this workspace settings
	/// </summary>
	ENV_UNSUPPORTED_ASSET
}
