using System.Collections;
using System.Collections.Generic;

namespace Slooh.Explorer.Library
{
    internal class LibraryTreeNodeComparer : IComparer, IComparer<LibraryTreeNode>
    {
        public int Compare(LibraryTreeNode x, LibraryTreeNode y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public int Compare(object x, object y)
        {
            return Compare((LibraryTreeNode)x, (LibraryTreeNode)y);
        }
    }
}
