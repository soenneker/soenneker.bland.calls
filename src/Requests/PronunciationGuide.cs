using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents the pronunciation guide used in the call request.
/// </summary>
public class PronunciationGuide
{
    [JsonPropertyName("word")]
    public string Word { get; set; }

    [JsonPropertyName("pronunciation")]
    public string Pronunciation { get; set; }

    [JsonPropertyName("case_sensitive")]
    public bool CaseSensitive { get; set; }

    [JsonPropertyName("spaced")]
    public bool Spaced { get; set; }
}