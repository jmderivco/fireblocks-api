namespace Fireblocks.Api.Tests;

public class BaseServiceTests
{
	protected readonly ITestOutputHelper TestOutputHelper;
	protected readonly IFireblocksApiConfig FireblocksApiConfig;
	protected readonly IJwtConfig JwtConfig;

	public BaseServiceTests(ITestOutputHelper testOutputHelper)
	{
		TestOutputHelper = testOutputHelper;
		FireblocksApiConfig = new FireblocksApiConfig
		{
			BaseUrl = "http://localhost",
			ApiKey = "TestApiKey",
			SecretKey = Environment.GetEnvironmentVariable("FireblocksApiConfigSecretKey") ?? "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\nEBS7ozZlG8cLglgyxLC8RouGxsAYog=="
				.Replace("\r\n", string.Empty)
				.Replace("\r", string.Empty)
				.Replace("\n", string.Empty)
		};
		JwtConfig = new JwtConfig()
		{
			Nonce = "D3D2D2H7RIKAL",
			IssueAt = new DateTimeOffset(2022, 10, 10, 0, 0, 0, TimeSpan.Zero),
			ExpiredInSeconds = 25
		};
	}

	protected static Task<ApiResponse<T>> CreateResponse<T>(HttpStatusCode statusCode)
		where T : IBaseResponseModel =>
			Task.FromResult(new ApiResponse<T>(
				new HttpResponseMessage(statusCode),
				default,
				new RefitSettings()));

	protected static Task<ApiResponse<IEnumerable<T>>> CreateIEnumerableResponse<T>(HttpStatusCode statusCode)
		where T : IBaseResponseModel =>
			Task.FromResult(new ApiResponse<IEnumerable<T>>(
				new HttpResponseMessage(statusCode),
				default,
				new RefitSettings()));
}
