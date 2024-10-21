using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the response received after initiating a call via the Bland AI API.
/// </summary>
public class CreateCallResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("call_id")]
    public string CallId { get; set; }

    [JsonPropertyName("batch_id")]
    public string BatchId { get; set; }
}