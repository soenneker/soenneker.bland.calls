using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

public class RequestData
{
    /// <summary>
    /// The phone number included in the original request.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Indicates whether the request waited.
    /// </summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }

    /// <summary>
    /// The language of the original request.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}