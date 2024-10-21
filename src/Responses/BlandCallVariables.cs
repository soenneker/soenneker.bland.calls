using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

public class BlandCallVariables
{
    [JsonPropertyName("now")]
    public string? Now { get; set; }

    [JsonPropertyName("now_utc")]
    public string? NowUtc { get; set; }

    [JsonPropertyName("short_from")]
    public string? ShortFrom { get; set; }

    [JsonPropertyName("short_to")]
    public string? ShortTo { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("to")]
    public string? To { get; set; }

    [JsonPropertyName("call_id")]
    public string? CallId { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("zip")]
    public string? Zip { get; set; }

    [JsonPropertyName("input")]
    public BlandCallInput? Input { get; set; }
}