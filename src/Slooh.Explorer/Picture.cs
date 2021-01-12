using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Slooh.Explorer
{
    class Picture : INotifyPropertyChanged
    {
        [JsonPropertyName("imageId")]
        public int Id { get; set; }
        [JsonPropertyName("imageTitle")]
        public string Title { get; set; }


        [JsonPropertyName("scheduledMissionId")]
        public int MissionId { get; set; }


        [JsonPropertyName("displayDate")]
        public string DisplayDate { get; set; }
        [JsonPropertyName("displayTime")]
        public string DisplayTime { get; set; }

        public DateTime Timestamp { get; set; }

        [JsonPropertyName("imageDownloadURL")]
        public string DownloadUrl { get; set; }
        [JsonPropertyName("imageDownloadFilename")]
        public string Filename { get; set; }

        [JsonPropertyName("telescopeName")]
        public string Telescope { get; set; }
        [JsonPropertyName("instrumentName")]
        public string Instrument { get; set; }
        [JsonPropertyName("overlayData")]
        public OverlayData Data { get; set; }
        public string Owner => Data?.Owner == "Not available" ? "" : Data?.Owner;


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public class OverlayData
        {
            [JsonPropertyName("owner")]
            public string Owner { get; set; }
        }
    }
}
