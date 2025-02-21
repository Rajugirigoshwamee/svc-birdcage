using System.Text.Json.Serialization;

namespace svc.birdcage.hawk.Response.Base;

public class BaseErrorResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("data")]
    public dynamic Data { get; set; }
}
