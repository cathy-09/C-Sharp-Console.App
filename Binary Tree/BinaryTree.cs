using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BinaryTree
    {
        public Nodes roots;
        public BinaryTree()
        {
            this.roots = null;
        }

        public void Insert(int data)
        {
            if (roots == null)
            {
                roots = new Nodes(data);
            }
            else
            {
                InsertRec(roots, new Nodes(data));
            }
        }

        private void InsertRec(Nodes roots, Nodes newNode)
        {
            if (newNode.Data < roots.Data)
            {
                if (roots.Left == null)
                {
                    roots.Left = newNode;
                }
                else
                {
                    InsertRec(roots.Left, newNode);
                }
            }
            else
            {
                if (roots.Right == null)
                {
                    roots.Right = newNode;
                }
                else
                {
                    InsertRec(roots.Right, newNode);
                }
            }
        }
        public void PrintTree(Nodes root, string indent, bool last)
        {
            if (root != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "     ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|    ";
                }
                Console.WriteLine(root.Data);
                PrintTree(root.Left, indent, false);
                PrintTree(root.Right, indent, true);
            }
        }

        //public void Order(Nodes nodes)
        //{
        //    if (nodes != null)
        //    {
        //        Order(nodes.Left);
        //        Console.WriteLine(nodes.Data + " ");
        //        Order(nodes.Right);
        //    }
        //}
    }
}
