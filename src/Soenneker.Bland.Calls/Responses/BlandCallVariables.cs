using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the bland call variables.
/// </summary>
public class BlandCallVariables
{
    /// <summary>
    /// Gets or sets now.
    /// </summary>
    [JsonPropertyName("now")]
    public string? Now { get; set; }

    /// <summary>
    /// Gets or sets now utc.
    /// </summary>
    [JsonPropertyName("now_utc")]
    public string? NowUtc { get; set; }

    /// <summary>
    /// Gets or sets short from.
    /// </summary>
    [JsonPropertyName("short_from")]
    public string? ShortFrom { get; set; }

    /// <summary>
    /// Gets or sets short to.
    /// </summary>
    [JsonPropertyName("short_to")]
    public string? ShortTo { get; set; }

    /// <summary>
    /// Gets or sets from.
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>
    /// Gets or sets to.
    /// </summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }

    /// <summary>
    /// Gets or sets call id.
    /// </summary>
    [JsonPropertyName("call_id")]
    public string? CallId { get; set; }

    /// <summary>
    /// Gets or sets phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets city.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Gets or sets state.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets zip.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? Zip { get; set; }

    /// <summary>
    /// Gets or sets input.
    /// </summary>
    [JsonPropertyName("input")]
    public BlandCallInput? Input { get; set; }
}