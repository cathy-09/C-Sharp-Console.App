namespace Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(5);
            binaryTree.Insert(4);
            binaryTree.Insert(3);
            binaryTree.Insert(2);
            binaryTree.Insert(1);
            binaryTree.Insert(6);
            binaryTree.Insert(7);

            binaryTree.PrintTree(binaryTree.roots, "", true);
        }
    }
}