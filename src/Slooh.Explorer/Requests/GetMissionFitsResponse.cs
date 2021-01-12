using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Slooh.Explorer.Requests
{
    class GetMissionFitsResponse : SloohResponse
    {
        [JsonPropertyName("groupList")]
        public FitsGroup[] Groups { get; set; }
    }

    class FitsGroup
    {
        [JsonPropertyName("groupName")]
        public string Name { get; set; }
        [JsonPropertyName("groupImageList")]
        public FitsImage[] Images { get; set; }
    }

    class FitsImage
    {
        [JsonPropertyName("imageUrl")]
        public string DownloadUrl { get; set; }
        [JsonPropertyName("imageTitle")]
        public string Title { get; set; }
    }
}
