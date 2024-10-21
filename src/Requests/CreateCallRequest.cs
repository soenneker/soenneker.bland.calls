namespace Soenneker.Bland.Calls.Requests;

using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the request body for creating a call.
/// </summary>
public class CreateCallRequest
{
    /// <summary>
    /// The phone number to call. Country code defaults to +1 (US) if not specified.
    /// For best results, use the E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Instructions for the agent, including the conversation flow, persona, and background.
    /// Provide relevant details and examples of the ideal conversation.
    /// </summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }

    /// <summary>
    /// The pathway ID for a pre-defined pathway in the developer portal.
    /// Only used when pathway_id is specified.
    /// </summary>
    [JsonPropertyName("pathway_id")]
    public string? PathwayId { get; set; }

    /// <summary>
    /// The node ID to start the pathway from. Only used when pathway_id is provided.
    /// </summary>
    [JsonPropertyName("start_node_id")]
    public string? StartNodeId { get; set; }

    /// <summary>
    /// The voice of the AI agent. Default: "mason". Other options include maya, ryan, adriana, etc.
    /// </summary>
    [JsonPropertyName("voice")]
    public string? Voice { get; set; } = "mason";

    /// <summary>
    /// Select an audio track to play in the background during the call.
    /// Default is null (phone static), other options include office, cafe, restaurant, none.
    /// </summary>
    [JsonPropertyName("background_track")]
    public string? BackgroundTrack { get; set; } = "null";

    /// <summary>
    /// Makes the agent say a specific phrase or sentence for its first response.
    /// </summary>
    [JsonPropertyName("first_sentence")]
    public string? FirstSentence { get; set; }

    /// <summary>
    /// Whether the agent should wait for the recipient to speak first. Default is false.
    /// </summary>
    [JsonPropertyName("wait_for_greeting")]
    public bool? WaitForGreeting { get; set; } = false;

    /// <summary>
    /// If true, the AI will not respond to interruptions. Default is false.
    /// </summary>
    [JsonPropertyName("block_interruptions")]
    public bool? BlockInterruptions { get; set; } = false;

    /// <summary>
    /// Adjusts how patient the AI is while waiting for the user to finish speaking. Default is 100.
    /// Range: 50-200.
    /// </summary>
    [JsonPropertyName("interruption_threshold")]
    public int? InterruptionThreshold { get; set; } = 100;

    /// <summary>
    /// The model to use for the call. Options: base, turbo, enhanced. Default: "enhanced".
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; } = "enhanced";

    /// <summary>
    /// Controls the randomness of the language model's responses. Range: 0.0 to 1.0. Default: 0.7.
    /// </summary>
    [JsonPropertyName("temperature")]
    public float? Temperature { get; set; } = 0.7f;

    /// <summary>
    /// Words that should be boosted in the transcription engine. Useful for proper nouns or frequently mis-transcribed words.
    /// </summary>
    [JsonPropertyName("keywords")]
    public List<string>? Keywords { get; set; } = new();

    /// <summary>
    /// Guides the agent on how to pronounce specific words. Useful for complicated terms or names.
    /// </summary>
    [JsonPropertyName("pronunciation_guide")]
    public List<PronunciationGuide>? PronunciationGuide { get; set; } = new();

    /// <summary>
    /// A phone number to transfer the call to under specific conditions (e.g., if the recipient asks to speak to a human).
    /// </summary>
    [JsonPropertyName("transfer_phone_number")]
    public string? TransferPhoneNumber { get; set; }

    /// <summary>
    /// A set of phone numbers the agent can transfer to, based on context or conditions.
    /// Overrides transfer_phone_number if transfer_list.default is specified.
    /// </summary>
    [JsonPropertyName("transfer_list")]
    public Dictionary<string, string>? TransferList { get; set; }

    /// <summary>
    /// The language to use for the call. Default: "en-US".
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; } = "en-US";

    /// <summary>
    /// The timezone for the call. Default: "America/Los_Angeles".
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; } = "America/Los_Angeles";

    /// <summary>
    /// Additional JSON data to be referenced during the call. Can be used with Prompt Variables.
    /// </summary>
    [JsonPropertyName("request_data")]
    public Dictionary<string, string>? RequestData { get; set; }

    /// <summary>
    /// Tools for interacting with the real world through API calls. Can be customized based on needs.
    /// </summary>
    [JsonPropertyName("tools")]
    public List<Dictionary<string, string>>? Tools { get; set; } = new();

    /// <summary>
    /// Dynamic requests to external APIs that can be used in the agent’s responses.
    /// </summary>
    [JsonPropertyName("dynamic_data")]
    public List<BlandCallDynamicData>? DynamicData { get; set; } = new();

    /// <summary>
    /// The start time for the call. If not specified, the call is sent immediately.
    /// Format: YYYY-MM-DD HH:MM:SS -HH:MM.
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// The message to leave if the AI encounters voicemail.
    /// </summary>
    [JsonPropertyName("voicemail_message")]
    public string? VoicemailMessage { get; set; }

    /// <summary>
    /// Specifies the action to take when encountering voicemail. Options: hangup, leave_message, ignore. Default: "hangup".
    /// </summary>
    [JsonPropertyName("voicemail_action")]
    public string? VoicemailAction { get; set; } = "hangup";

    /// <summary>
    /// Settings for retrying the call if it goes to voicemail. Includes delay, voicemail_action, and voicemail_message.
    /// </summary>
    [JsonPropertyName("retry")]
    public BlandCallRetry? BlandCallRetry { get; set; }

    /// <summary>
    /// The maximum duration of the call in minutes. Default: 30.
    /// </summary>
    [JsonPropertyName("max_duration")]
    public int? MaxDuration { get; set; } = 30;

    /// <summary>
    /// Whether to record the call. Default: false.
    /// </summary>
    [JsonPropertyName("record")]
    public bool? Record { get; set; } = false;

    /// <summary>
    /// The phone number to call from. Country code is required.
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>
    /// The URL to send call details to when the call ends.
    /// </summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>
    /// Events to stream to the webhook during the call. Options: queue, call, latency, webhook, tool, dynamic_data.
    /// </summary>
    [JsonPropertyName("webhook_events")]
    public List<string>? WebhookEvents { get; set; } = new();

    /// <summary>
    /// Additional metadata associated with the call.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Instructions for generating a call summary at the end of the call.
    /// </summary>
    [JsonPropertyName("summary_prompt")]
    public string? SummaryPrompt { get; set; }

    /// <summary>
    /// Additional instructions for the analysis schema.
    /// </summary>
    [JsonPropertyName("analysis_prompt")]
    public string? AnalysisPrompt { get; set; }

    /// <summary>
    /// Defines how to analyze the call transcript and data, specifying the structure and fields of interest.
    /// </summary>
    [JsonPropertyName("analysis_schema")]
    public Dictionary<string, string>? AnalysisSchema { get; set; }

    /// <summary>
    /// If true, the system will process the call to determine if it was answered by a human, unknown, or voicemail. Default is false.
    /// </summary>
    [JsonPropertyName("answered_by_enabled")]
    public bool? AnsweredByEnabled { get; set; } = false;
}
