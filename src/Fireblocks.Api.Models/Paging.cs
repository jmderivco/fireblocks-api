namespace Fireblocks.Api.Models;

/// <summary>
/// This object contains two fields: "before" (string) and “after” (string)
/// </summary>
public class Paging
{
	public string? Before { get; set; }
	public string? After { get; set; }
}
