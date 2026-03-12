using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

public class BlandCallInput
{
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("rooms")]
    public int? Rooms { get; set; }
}