using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents response data configuration for dynamic data.
/// </summary>
public class ResponseData
{
    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets data.
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }

    /// <summary>
    /// Gets or sets context.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; }
}