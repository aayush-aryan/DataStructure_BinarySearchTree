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
            binarySearchTree.InsertData(60);
            binarySearchTree.InsertData(95);
            binarySearchTree.InsertData(11);
            binarySearchTree.InsertData(65);
            binarySearchTree.InsertData(3);
            binarySearchTree.InsertData(16);
            binarySearchTree.InsertData(63);
            binarySearchTree.InsertData(67);
            binarySearchTree.Display(binarySearchTree.GetRoot());
            Console.WriteLine("NumberOfElements in BST is : " + binarySearchTree.GetSize());
            Console.WriteLine();
            bool result = binarySearchTree.SearchData(63, binarySearchTree.GetRoot());
            Console.WriteLine(result);
        }
    }
}
