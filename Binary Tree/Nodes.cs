using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class Nodes
    {
        public int Data;
        public Nodes Left;
        public Nodes Right;
        public Nodes(int data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }
}
