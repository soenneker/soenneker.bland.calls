using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents a request to initiate a call via the Bland AI API.
/// </summary>
public class CallRequest
{
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("task")]
    public string Task { get; set; }

    [JsonPropertyName("pathway_id")]
    public string PathwayId { get; set; }

    [JsonPropertyName("start_node_id")]
    public string StartNodeId { get; set; }

    [JsonPropertyName("voice")]
    public string Voice { get; set; } = "mason";

    [JsonPropertyName("background_track")]
    public string BackgroundTrack { get; set; } = "null";

    [JsonPropertyName("first_sentence")]
    public string FirstSentence { get; set; }

    [JsonPropertyName("wait_for_greeting")]
    public bool WaitForGreeting { get; set; } = false;

    [JsonPropertyName("block_interruptions")]
    public bool BlockInterruptions { get; set; } = false;

    [JsonPropertyName("interruption_threshold")]
    public int InterruptionThreshold { get; set; } = 100;

    [JsonPropertyName("model")]
    public string Model { get; set; } = "enhanced";

    [JsonPropertyName("temperature")]
    public float Temperature { get; set; } = 0.7f;

    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; } = [];

    [JsonPropertyName("pronunciation_guide")]
    public List<PronunciationGuide> PronunciationGuide { get; set; } = [];

    [JsonPropertyName("transfer_phone_number")]
    public string TransferPhoneNumber { get; set; }

    [JsonPropertyName("transfer_list")]
    public Dictionary<string, string> TransferList { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; } = "en-US";

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = "America/Los_Angeles";

    [JsonPropertyName("request_data")]
    public Dictionary<string, string> RequestData { get; set; }

    [JsonPropertyName("tools")]
    public List<Dictionary<string, string>> Tools { get; set; } = [];

    [JsonPropertyName("dynamic_data")]
    public List<DynamicData> DynamicData { get; set; } = [];

    [JsonPropertyName("start_time")]
    public string StartTime { get; set; }

    [JsonPropertyName("voicemail_message")]
    public string VoicemailMessage { get; set; }

    [JsonPropertyName("voicemail_action")]
    public string VoicemailAction { get; set; } = "hangup";

    [JsonPropertyName("retry")]
    public Retry Retry { get; set; }

    [JsonPropertyName("max_duration")]
    public int MaxDuration { get; set; } = 30;

    [JsonPropertyName("record")]
    public bool Record { get; set; } = false;

    [JsonPropertyName("from")]
    public string From { get; set; }

    [JsonPropertyName("webhook")]
    public string Webhook { get; set; }

    [JsonPropertyName("webhook_events")]
    public List<string> WebhookEvents { get; set; } = [];

    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; }

    [JsonPropertyName("summary_prompt")]
    public string SummaryPrompt { get; set; }

    [JsonPropertyName("analysis_prompt")]
    public string AnalysisPrompt { get; set; }

    [JsonPropertyName("analysis_schema")]
    public Dictionary<string, string> AnalysisSchema { get; set; }

    [JsonPropertyName("answered_by_enabled")]
    public bool AnsweredByEnabled { get; set; } = false;
}