using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Slooh.Explorer
{
    class Mission : INotifyPropertyChanged
    {
        [JsonPropertyName("scheduledMissionId")]
        public int Id { get; set; }
        [JsonPropertyName("imageTitle")]
        public string Title { get; set; }

        #region PicturesState
        private MissionPictures _picturesState;
        public MissionPictures PicturesState
        {
            get => _picturesState;
            set
            {
                if (value == _picturesState) return;
                _picturesState = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region State
        private MissionState _state;
        public MissionState State
        {
            get => _state;
            set
            {
                if (value == _state) return;
                _state = value;
                OnPropertyChanged();
            }
        }

        private bool _thumbnailArrived;

        public bool ThumbnailArrived
        {
            get => _thumbnailArrived; 
            set 
            { 
                if (_thumbnailArrived == value) return;
                _thumbnailArrived = value;
                OnPropertyChanged();
            }
        }

        #endregion


        [JsonPropertyName("displayDate")]
        public string DisplayDate { get; set; }
        [JsonPropertyName("displayTime")]
        public string DisplayTime { get; set; }

        #region Timestamp
        private DateTime _timestamp;
        
        public DateTime Timestamp
        {
            get => _timestamp;
            set
            {
                if (value == _timestamp) return;
                _timestamp = value;
                OnPropertyChanged();
            }
        }
        #endregion

        [JsonPropertyName("imageURL")]
        public string ImageUrl { get; set; }


        [JsonPropertyName("missionImageCount")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int ImageCount { get; set; }
        [JsonPropertyName("missionOwner")]
        public string Owner { get; set; }
        [JsonPropertyName("fitsIsAvailable")]
        public bool HasFits { get; set; }
        [JsonPropertyName("telescopeName")]
        public string Telescope { get; set; }
        [JsonPropertyName("instrumentName")]
        public string Instrument { get; set; }

        public BindingList<Picture> Pictures { get; } = new BindingList<Picture>();
        public List<Picture> FitsPictures { get; } = new List<Picture>();
        public string Folder { get; set; }

        public override string ToString()
        {
            return $"Mission - {Title} - {Timestamp} - {ImageCount} images";
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    enum MissionState
    {
        None,
        Scheduled,
        FindPictures,
        FindFITS,
        Downloading,
        Deleting,
        Finished,
    }

    enum MissionPictures
    {
        Unknown,
        Fetching,
        None,
        Incomplete,
        Exists
    }
}
