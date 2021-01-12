using System.Text.Json.Serialization;

namespace Slooh.Explorer.Requests
{
    class LogonResponse : SloohResponse
	{
		[JsonPropertyName("loginError")] 
		public string LoginError { get; set; }

        [JsonPropertyName("fname")] 
		public string Name { get; set; }

		[JsonPropertyName("userid")] 
		public string UserId { get; set; }

		[JsonPropertyName("displayName")]
		public string DisplayName { get; set; }

		[JsonPropertyName("avatarURL")]
		public string AvatarUrl { get; set; }

		[JsonPropertyName("cid")]
		public string Cid { get; set; }

		[JsonPropertyName("customerUUID")]
		public string CustomerUuid { get; set; }

		[JsonPropertyName("at")]
		public string At { get; set; }

		[JsonPropertyName("membershipType")]
		public string MembershipType { get; set; }

		[JsonPropertyName("subscriptionPlanName")]
		public string SubscriptionPlanName { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("token")]
		public string Token { get; set; }
    }
}
