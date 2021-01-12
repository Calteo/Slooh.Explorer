using System.Text.Json.Serialization;

namespace Slooh.Explorer.Requests

{
    class SessionInfoResponse : SloohResponse
    {
        [JsonPropertyName("sloohSessionToken")]
        public string SloohSessionToken { get; set; }
    }
}
