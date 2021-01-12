using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Slooh.Explorer.Requests
{
    class SloohResponse
    {
        static SloohResponse()
        {
            Properties = typeof(SloohSite).GetProperties().ToDictionary(p => p.Name);
        }

        private static Dictionary<string, PropertyInfo> Properties { get; }

        public virtual void CopyTo(SloohSite site)
        {
            foreach (var property in GetType().GetProperties())
            {
                if (Properties.TryGetValue(property.Name, out var siteProperty))
                {
                    var value = property.GetValue(this);
                    siteProperty.SetValue(site, value);
                }
            }
        }

        [JsonPropertyName("apiError")]
        public bool ApiError { get; set; }
        [JsonPropertyName("errorCode")]
        public int ErrorCode { get; set; }
        [JsonPropertyName("errorMsg")]
        public string ErrorMessage { get; set; }
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }        

        public void EnsureSuccess()
        {
            if (ApiError)
                throw new Exception($"Failed get {GetType().Name} - {ErrorCode}:{ErrorMessage} ({StatusCode})");
        }
    }
}
