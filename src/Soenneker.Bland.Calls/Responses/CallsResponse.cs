using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Responses;

/// <summary>
/// Represents the response for a call data query.
/// </summary>
public class CallsResponse
{
    /// <summary>
    /// The total number of calls that match the query filters. This number may be greater than the number of calls returned in the response.
    /// 
    /// For example:
    /// - If you have 10,000 calls, and don’t include any filters, the total_count will be 10,000.
    /// - If you have 10,000 calls and 9,000 of them match the query, the total_count will be 9,000 regardless of the number of calls returned in the response.
    /// </summary>
    [JsonPropertyName("total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// The number of calls returned in the response.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// An array of call data objects. Individual call transcripts are not included due to their size.
    /// </summary>
    [JsonPropertyName("calls")]
    public List<CallDetailsResponse>? Calls { get; set; }
}