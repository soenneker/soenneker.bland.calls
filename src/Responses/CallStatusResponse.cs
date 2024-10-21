using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the status response of a call request.
/// </summary>
public record CallStatusResponse
{
    /// <summary>
    /// The status of the call request. Can be either "success" or "error".
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// A message providing additional details about the status. 
    /// - If the status is "success", the message will be "Call ended successfully."
    /// - If the status is "error", the message will indicate the issue, such as "SID not found for the given c_id." or "Internal server error."
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// The number of active calls that will be cancelled.
    /// </summary>
    [JsonPropertyName("num_calls")]
    public int? NumberOfCalls { get; set; }
}