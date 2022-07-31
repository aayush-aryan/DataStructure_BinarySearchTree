using System;

namespace Section4BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to section-4 BinarySearchTree!");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.Display(binarySearchTree.GetRoot());
        }
    }
}
