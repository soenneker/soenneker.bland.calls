using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the bland call transcript.
/// </summary>
public class BlandCallTranscript
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets created at.
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets text.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// Gets or sets user.
    /// </summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }

    /// <summary>
    /// Gets or sets call id.
    /// </summary>
    [JsonPropertyName("c_id")]
    public string? CallId { get; set; }

    /// <summary>
    /// Gets or sets status.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets transcript id.
    /// </summary>
    [JsonPropertyName("transcript_id")]
    public string? TranscriptId { get; set; }
}