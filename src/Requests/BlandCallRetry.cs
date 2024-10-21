using System.Text.Json.Serialization;

namespace Soenneker.Bland.Calls.Requests;

/// <summary>
/// Represents retry options for the call request.
/// </summary>
public class BlandCallRetry
{
    [JsonPropertyName("wait")]
    public int Wait { get; set; }

    [JsonPropertyName("voicemail_action")]
    public string VoicemailAction { get; set; }

    [JsonPropertyName("voicemail_message")]
    public string VoicemailMessage { get; set; }
}