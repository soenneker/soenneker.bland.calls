using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents the pronunciation guide used in the call request.
/// </summary>
public class PronunciationGuide
{
    /// <summary>
    /// Gets or sets word.
    /// </summary>
    [JsonPropertyName("word")]
    public string Word { get; set; }

    /// <summary>
    /// Gets or sets pronunciation.
    /// </summary>
    [JsonPropertyName("pronunciation")]
    public string Pronunciation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether case sensitive.
    /// </summary>
    [JsonPropertyName("case_sensitive")]
    public bool CaseSensitive { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether spaced.
    /// </summary>
    [JsonPropertyName("spaced")]
    public bool Spaced { get; set; }
}