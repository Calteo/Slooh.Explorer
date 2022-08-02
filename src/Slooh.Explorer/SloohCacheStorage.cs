using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slooh.Explorer
{
    internal abstract class SloohCacheStorage<TData, TKey> : SloohCacheStorageBase
    {
        protected SloohCacheStorage(SloohCache cache, string folder) : base(cache, folder)
        {
        }

        public TData Get(TKey key)
        {
            var filename = Path.Combine(Folder, GetFilename(key));
            if (File.Exists(filename))
            {
                using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return Read(stream);
                }
            }
            
            return CacheMiss(key);
        }


        protected void Set(TKey key, TData data)
        {
            var filename = Path.Combine(Folder, GetFilename(key));
            using (var stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Write(stream, data);
            }
        }

        protected abstract string GetFilename(TKey key);
        protected abstract void Write(Stream stream, TData data);
        protected abstract TData Read(Stream stream);
        protected abstract TData CacheMiss(TKey key);
    }
}
