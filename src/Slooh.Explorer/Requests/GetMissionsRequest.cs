﻿using System.Text.Json.Serialization;

namespace Slooh.Explorer.Requests
{
    class GetMissionsRequest : SloohRequest
    {
        [JsonPropertyName("sloohSiteSessionToken")]
        public string SloohSessionToken { get; set; }
        [JsonPropertyName("at")]
        public string At { get; set; }
        [JsonPropertyName("cid")]
        public string Cid { get; set; }
        [JsonPropertyName("token")]
        public string Token { get; set; }
        [JsonPropertyName("productId")]
        public string ProductId { get; set; } = "ee26fb6d-3351-11eb-83b9-0655cc43ca95";
        [JsonPropertyName("locale")]
        public string Locale { get; set; } = "en";

        [JsonPropertyName("maxMissionCount")]
        public int Maximum { get; set; } = 18;
        [JsonPropertyName("firstMissionNumber")]
        public int First { get; set; } = 1;
    }
}
