using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents response data configuration for dynamic data.
/// </summary>
public class ResponseData
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("context")]
    public string Context { get; set; }
}