using System;

namespace LeavesInDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert all leaves of a binary search tree in a DLL");
            int[] treeElements = {100, 50, 150, 25, 70, 130, 180};
            BinaryTree binaryTree = new BinaryTree();
            for (int index = 0; index < treeElements.Length; index++) {
                binaryTree.root = binaryTree.insertBinaryTree(treeElements[index]);
            }
            binaryTree.getDLL(binaryTree.root);
            Console.ReadKey();
        }
    }
}
