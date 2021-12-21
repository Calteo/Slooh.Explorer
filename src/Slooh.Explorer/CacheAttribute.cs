using System;

namespace Slooh.Explorer
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class CacheAttribute : Attribute
    {
        public CacheAttribute(string folder)
        {
            Folder = folder;
        }

        public string Folder { get; }
    }
}
