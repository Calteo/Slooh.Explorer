using System.Text.Json.Serialization;

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
        [JsonPropertyName("imageURL")]
        public string DownloadUrl { get; set; }
        [JsonPropertyName("imageTitle")]
        public string Title { get; set; }
    }
}
