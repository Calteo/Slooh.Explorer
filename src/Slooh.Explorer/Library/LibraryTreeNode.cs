using System.Collections.Generic;
using System.Windows.Forms;

namespace Slooh.Explorer.Library
{
    internal class LibraryTreeNode : TreeNode
    {
        public LibraryTreeNode(string text) : base(text)
        {

        }

        public HashSet<MissionInfo> Missions { get; } = new HashSet<MissionInfo>();
    }
}
