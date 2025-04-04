using Fireblocks.Api.Enums;

namespace Fireblocks.Api.Models.Requests.Params;

public class GetPublicKeyInfoParams : GetPublicKeyInfoForVaultAccountParams
{
	/// <summary>
	/// String, one of the supported SigningAlgorithms
	/// </summary>
	public SigningAlgorithm? algorithm { get; set; }

	/// <summary>
	/// List of integers
	/// </summary>
	public IEnumerable<int>? derivationPath { get; set; }
}
