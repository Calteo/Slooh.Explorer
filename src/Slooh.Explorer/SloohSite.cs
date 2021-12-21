using Slooh.Explorer.Requests;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows;
using Toolbox;

namespace Slooh.Explorer
{
    class SloohSite
    {
        public SloohSite()
        {
            Client = new HttpClient(Handler);
            Name = "";
            Cache = new SloohCache();
        }

        protected const string RootUrl = "https://www.slooh.com";

        private HttpClientHandler Handler { get; } = new HttpClientHandler();
        private HttpClient Client { get; }
        private SloohCache Cache { get; }

        public string Username { get; set; }
        public string Passwd { get; set; }
        public string SloohSessionToken { get; private set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string AvatarUrl { get; set; }
        public string Cid { get; set; }
        public string CustomerUuid { get; set; }
        public string At { get; set; }
        public string MembershipType { get; set; }
        public string SubscriptionPlanName { get; set; }
        public string Status { get; set; }
        public string Token { get; set; }
        public string MemberSince { get; set; }
        public int Points { get; set; }
        public string Tier { get; set; }
        public string NextTier { get; set; }
        public int ProgressPoints { get; set; }
        public int NeededPoints { get; set; }

        public async Task GetSessionToken()
        {
            var response = await Client.PostAsync(RootUrl + "/api/app/generateSessionToken", null);
            response.EnsureSuccessStatusCode();

            var sessionInfo = await response.Content.ReadFromJsonAsync<SessionInfoResponse>();
            sessionInfo.EnsureSuccess();
            sessionInfo.CopyTo(this);

            Handler.CookieContainer.Add(new System.Net.Cookie("_sloohsstkn", SloohSessionToken, "/", ".slooh.com"));
        }

        public async Task Logon()
        {
            var logonInfo = new LogonRequest();
            logonInfo.FillFrom(this);

            var response = await Client.PostAsJsonAsync(RootUrl + "/api/users/login", logonInfo);
            response.EnsureSuccessStatusCode();

            var logonResponse = await response.Content.ReadFromJsonAsync<LogonResponse>();
            logonResponse.EnsureSuccess();
            logonResponse.CopyTo(this);
        }

        public async Task GetGravityStatus()
        {
            var logonInfo = new GetGravityStatusRequest();
            logonInfo.FillFrom(this);

            var response = await Client.PostAsJsonAsync(RootUrl + "/api/newdashboard/getUserGravityStatus", logonInfo);
            response.EnsureSuccessStatusCode();

            var gravityResponse = await response.Content.ReadFromJsonAsync<GetGravityStatusResponse>();
            gravityResponse.EnsureSuccess();
            gravityResponse.CopyTo(this);            
        }

        public async Task<GetMissionsResponse> GetMissions(int first = 1)
        {
            var request = new GetMissionsRequest();
            request.FillFrom(this);
            request.First = first;

            var response = await Client.PostAsJsonAsync(RootUrl + "/api/images/getMissionImages", request);
            response.EnsureSuccessStatusCode();

            var missionsResponse = await response.Content.ReadFromJsonAsync<GetMissionsResponse>();
            missionsResponse.EnsureSuccess();

            foreach (var mission in missionsResponse.Missions)
            {
                mission.Title = mission.Title.Trim();
                var timestamp = DateTime.Parse(mission.DisplayDate);
                var clock = DateTime.Parse(mission.DisplayTime.Replace(" UTC", ""));
                timestamp = timestamp.AddHours(clock.Hour).AddMinutes(clock.Minute).AddSeconds(clock.Second);
                mission.Timestamp = DateTime.SpecifyKind(timestamp, DateTimeKind.Utc);
            }

            return missionsResponse;
        }

        internal void ClearCache()
        {
            Cache.Clear();
        }

        public async Task<GetPicturesResponse> GetPictures(int first = 1, int missionId = 0)
        {
            GetPicturesResponse picturesResponse = null;

            if (missionId != 0)
            {
                picturesResponse = Cache.Fetch<GetPicturesResponse>(missionId);
            }

            if (picturesResponse == null)
            {
                var request = new GetPicturesRequest();
                request.FillFrom(this);
                request.First = first;
                request.Id = missionId;

                var response = await Client.PostAsJsonAsync(RootUrl + "/api/images/getMyPictures", request);
                response.EnsureSuccessStatusCode();

                picturesResponse = await response.Content.ReadFromJsonAsync<GetPicturesResponse>();
                picturesResponse.EnsureSuccess();

                if (missionId != 0)
                    Cache.Insert(missionId, picturesResponse);
            }

            foreach (var picture in picturesResponse.Pictures)
            {
                picture.SloohSite = this;
                picture.Title = picture.Title.Trim();

                var timestamp = DateTime.Parse(picture.DisplayDate);
                var clock = DateTime.Parse(picture.DisplayTime.Replace(" UTC", ""));
                timestamp = timestamp.AddHours(clock.Hour).AddMinutes(clock.Minute).AddSeconds(clock.Second);
                picture.Timestamp = DateTime.SpecifyKind(timestamp, DateTimeKind.Utc);
                if (picture.Telescope.IsEmpty()) picture.Telescope = "Unknown";
                if (picture.Instrument.IsEmpty()) picture.Instrument = "Unknown";
            }

            return picturesResponse;
        }

        public async Task<GetMissionFitsResponse> GetMissionFits(int missionId)
        {
            var request = new GetPicturesRequest();
            request.FillFrom(this);
            request.Id = missionId;

            var response = await Client.PostAsJsonAsync(RootUrl + "/api/images/getMissionFITS", request);
            response.EnsureSuccessStatusCode();

            var fitsResponse = await response.Content.ReadFromJsonAsync<GetMissionFitsResponse>();
            fitsResponse.EnsureSuccess();

            /*
            foreach (var picture in picturesResponse.Pictures)
            {
                var timestamp = DateTime.Parse(picture.DisplayDate);
                var clock = DateTime.Parse(picture.DisplayTime.Replace(" UTC", ""));
                timestamp = timestamp.AddHours(clock.Hour).AddMinutes(clock.Minute).AddSeconds(clock.Second);
                picture.Timestamp = DateTime.SpecifyKind(timestamp, DateTimeKind.Utc);
            }
            */

            return fitsResponse;
        }

        public async Task<Stream> GetPicture(string url)
        {
            return await Client.GetStreamAsync(url);
        }

        internal async Task DeletePicture(Picture picture)
        {
            var request = new DeletePictureRequest();
            request.FillFrom(this);
            
            request.CustomerImageId = picture.CustomerImageId;

            var response = await Client.PostAsJsonAsync(RootUrl + "/api/images/deleteImage", request);
            response.EnsureSuccessStatusCode();

            var fitsResponse = await response.Content.ReadFromJsonAsync<DeletePictureResponse>();
            fitsResponse.EnsureSuccess();
        }
    }
}