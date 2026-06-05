using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents retry options for the call request.
/// </summary>
public class BlandCallRetry
{
    /// <summary>
    /// Gets or sets wait.
    /// </summary>
    [JsonPropertyName("wait")]
    public int Wait { get; set; }

    /// <summary>
    /// Gets or sets voicemail action.
    /// </summary>
    [JsonPropertyName("voicemail_action")]
    public string VoicemailAction { get; set; }

    /// <summary>
    /// Gets or sets voicemail message.
    /// </summary>
    [JsonPropertyName("voicemail_message")]
    public string VoicemailMessage { get; set; }
}