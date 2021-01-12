using System.Text.Json.Serialization;

namespace Slooh.Explorer.Requests
{
    class GetGravityStatusResponse : SloohResponse
    {
		[JsonPropertyName("memberSince")]
		public string MemberSince { get; set; }
		[JsonPropertyName("gravityPoints")] 
		public int Points { get; set; }
		[JsonPropertyName("currentTierName")]
		public string Tier { get; set; }
		[JsonPropertyName("nextTierName")]
		public string NextTier { get; set; }
		[JsonPropertyName("currentTierProgress")]
		public int ProgressPoints { get; set; }
		[JsonPropertyName("maxTierProgress")]
		public int NeededPoints { get; set; }
    }
}
