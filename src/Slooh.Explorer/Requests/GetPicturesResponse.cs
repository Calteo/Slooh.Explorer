using System.Text.Json.Serialization;

namespace Slooh.Explorer.Requests
{
    [Cache("GetPictures")]
    class GetPicturesResponse : SloohResponse
    {
        [JsonPropertyName("maxImageCount")]
        public int Maximum { get; set; }
        [JsonPropertyName("firstImageNumber")]
        public int First { get; set; }
        [JsonPropertyName("imageCount")]
        public int Count { get; set; }
        [JsonPropertyName("totalCount")]
        public int Total { get; set; }

        [JsonPropertyName("imageList")]
        public Picture[] Pictures { get; set; }
    }
}
