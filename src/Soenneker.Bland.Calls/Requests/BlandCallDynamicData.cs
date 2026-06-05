using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents the dynamic data used in the call request.
/// </summary>
public class BlandCallDynamicData
{
    /// <summary>
    /// Gets or sets url.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or sets response data.
    /// </summary>
    [JsonPropertyName("response_data")]
    public List<ResponseData> ResponseData { get; set; } = [];
}