using System;
using System.Buffers;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using Slooh.Explorer.Requests;
using Toolbox;

namespace Slooh.Explorer
{
    class SloohCache
    {
        public SloohCache(SloohSite site)
        {
            Site = site;

            Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Slooh.Explorer", "Cache");
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);

            MissionThumbnails = new SloohCacheStorageMissionThumbnails(this);
        }

        public SloohSite Site { get; }

        public string Folder { get; private set; }

        public SloohCacheStorageMissionThumbnails MissionThumbnails { get; }


        private string GetRequestFilename<T>(int id) where T : SloohResponse
        {
            var typeFolder = typeof(T).GetCustomAttributes(typeof(CacheAttribute), false).Cast<CacheAttribute>().FirstOrDefault()?.Folder;
            if (typeFolder.IsEmpty()) return null;

            var folder = Path.Combine(Folder, typeFolder);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return Path.Combine(folder, $"{id}.json");
        }

        public void InsertRequest<T>(int id, T response) where T : SloohResponse
        {
            var filename = GetRequestFilename<T>(id);
            try
            {
                if (filename.NotEmpty())
                {
                    using (var stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (var writer = new Utf8JsonWriter(stream))
                        {
                            JsonSerializer.Serialize(writer, response);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception.Message, $"Cache.Insert[{filename}]");
            }
        }

        public T FetchRequest<T>(int id) where T : SloohResponse
        {
            var filename = GetRequestFilename<T>(id);
            try
            {                
                if (filename.NotEmpty() && File.Exists(filename))
                {
                    using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        var buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, (int)stream.Length);

                        var reader = new Utf8JsonReader(new ReadOnlySequence<byte>(buffer));
                        return JsonSerializer.Deserialize<T>(ref reader);
                    }
                }
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception.Message, $"Cache.Fetch[{filename}]");
            }
            return null;
        }

        internal void Clear()
        {
            foreach (var file in Directory.EnumerateFiles(Folder, "*", new EnumerationOptions { IgnoreInaccessible = true, RecurseSubdirectories = true }))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception exception)
                {
                    Trace.WriteLine(exception.Message, $"Cache.Clear[{file}]");
                }
            }
        }        
    }
}
