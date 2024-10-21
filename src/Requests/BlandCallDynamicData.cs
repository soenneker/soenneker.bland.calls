using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents the dynamic data used in the call request.
/// </summary>
public class BlandCallDynamicData
{
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("response_data")]
    public List<ResponseData> ResponseData { get; set; } = [];
}