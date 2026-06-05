using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the response received after initiating a call via the Bland AI API.
/// </summary>
public class CreateCallResponse
{
    /// <summary>
    /// Gets or sets status.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets message.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or sets call id.
    /// </summary>
    [JsonPropertyName("call_id")]
    public string CallId { get; set; }

    /// <summary>
    /// Gets or sets batch id.
    /// </summary>
    [JsonPropertyName("batch_id")]
    public string BatchId { get; set; }
}