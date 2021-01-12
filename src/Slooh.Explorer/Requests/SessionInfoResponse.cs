using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Slooh.Explorer.Requests

{
    class SessionInfoResponse : SloohResponse
    {
        [JsonPropertyName("sloohSessionToken")]
        public string SloohSessionToken { get; set; }
    }
}
