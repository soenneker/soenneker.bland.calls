using System.Text.Json.Serialization;
using Soenneker.Bland.Calls.Requests;

namespace Soenneker.Bland.Calls;

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(CallFilterRequest))]
internal partial class BlandCallJsonContext : JsonSerializerContext
{
}
