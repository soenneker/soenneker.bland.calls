using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

public class BlandCallTranscript
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    [JsonPropertyName("c_id")]
    public string? CallId { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("transcript_id")]
    public string? TranscriptId { get; set; }
}