namespace Slooh.Explorer.Requests
{
    class LogonRequest : SloohRequest
    {
        public string Username { get; set; }
        public string Passwd { get; set; }
        public string SloohSiteSessionToken { get; set; }
        public string ProductId { get; set; } = "ee26fb6d-3351-11eb-83b9-0655cc43ca95";
        public string Locale { get; set; } = "en";
    }
}
