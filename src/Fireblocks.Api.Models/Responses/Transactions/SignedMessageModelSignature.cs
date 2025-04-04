namespace Fireblocks.Api.Models.Responses;

public class SignedMessageModelSignature
{
	public string? R { get; set; }
	public string? S { get; set; }
	public long? V { get; set; }
}
