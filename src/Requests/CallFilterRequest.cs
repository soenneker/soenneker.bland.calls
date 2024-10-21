namespace Soenneker.Bland.Calls.Requests;
using System.Text.Json.Serialization;

/// <summary>
/// Represents the filter parameters for retrieving call data.
/// </summary>
public class CallFilterRequest
{
    /// <summary>
    /// Filter calls by the number they were dispatched from.
    /// The number that initiated the call - the user’s phone number for inbound calls, 
    /// or the number your AI Agent called from for outbound calls.
    /// </summary>
    [JsonPropertyName("from_number")]
    public string? FromNumber { get; set; }

    /// <summary>
    /// Filter calls by the number they were dispatched to.
    /// The number that answered the call - the user’s phone number for outbound calls,
    /// or your AI Agent’s number for inbound calls.
    /// </summary>
    [JsonPropertyName("to_number")]
    public string? ToNumber { get; set; }

    /// <summary>
    /// The starting index (inclusive) for the range of calls to retrieve.
    /// </summary>
    [JsonPropertyName("from")]
    public int? From { get; set; }

    /// <summary>
    /// The ending index for the range of calls to retrieve.
    /// </summary>
    [JsonPropertyName("to")]
    public int? To { get; set; }

    /// <summary>
    /// The maximum number of calls to return in the response. Default is 1000.
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; } = 1000;

    /// <summary>
    /// Whether to sort the calls in ascending order of their creation time. Default is false.
    /// </summary>
    [JsonPropertyName("ascending")]
    public bool? Ascending { get; set; } = false;

    /// <summary>
    /// Get calls including and after a specific date. Format: YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    /// <summary>
    /// Get calls including and before a specific date. Format: YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// Get calls for a specific date. Can’t be used with end_date or start_date. Format: YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    /// <summary>
    /// Whether to filter calls by complete status.
    /// </summary>
    [JsonPropertyName("completed")]
    public bool? Completed { get; set; }

    /// <summary>
    /// Get calls from a specific batch.
    /// </summary>
    [JsonPropertyName("batch_id")]
    public string? BatchId { get; set; }

    /// <summary>
    /// Filter by answered_by type. Example: human.
    /// </summary>
    [JsonPropertyName("answered_by")]
    public string? AnsweredBy { get; set; }

    /// <summary>
    /// Whether to filter based on inbound or not.
    /// </summary>
    [JsonPropertyName("inbound")]
    public bool? Inbound { get; set; }

    /// <summary>
    /// Duration (call length) greater than the value provided. Example: 0.5 (for half a minute).
    /// </summary>
    [JsonPropertyName("duration_gt")]
    public float? DurationGreaterThan { get; set; }

    /// <summary>
    /// Duration (call length) less than the value provided. Example: 0.5 (for half a minute).
    /// </summary>
    [JsonPropertyName("duration_lt")]
    public float? DurationLessThan { get; set; }

    /// <summary>
    /// Get calls for a specific campaign ID.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; set; }
}
