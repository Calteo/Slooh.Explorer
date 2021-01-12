using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Slooh.Explorer.Requests
{
    class GetMissionsResponse : SloohResponse
    {
        [JsonPropertyName("firstMissionNumber")]
        public int First { get; set; }
        [JsonPropertyName("totalCount")]
        public int Total { get; set; }
        [JsonPropertyName("imageCount")]
        public int Count { get; set; }

        [JsonPropertyName("imageList")]
        public Mission[] Missions { get; set; }
    }
}
