using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slooh.Explorer
{
    internal abstract class SloohCacheStorageBase
    {
        protected SloohCacheStorageBase(SloohCache cache, string folder)
        {
            Cache = cache;
            Site = Cache.Site;

            Folder = Path.Combine(Cache.Folder, folder);

            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
        }

        public SloohCache Cache { get; }
        public SloohSite Site { get; }
        public string Folder { get; }
    }
}
