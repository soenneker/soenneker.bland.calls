using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the bland call input.
/// </summary>
public class BlandCallInput
{
    /// <summary>
    /// Gets or sets date.
    /// </summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>
    /// Gets or sets rooms.
    /// </summary>
    [JsonPropertyName("rooms")]
    public int? Rooms { get; set; }
}