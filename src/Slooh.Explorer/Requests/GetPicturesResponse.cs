using System.Text.Json.Serialization;
using Toolbox;
using Windows.Media.Core;

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
        public string TotalCount { get; set; }
        public int Total => TotalCount.IsEmpty() ? 0 : int.Parse(TotalCount);

        [JsonPropertyName("imageList")]
        public Picture[] Pictures { get; set; }
    }
}
