using System;
using System.Collections.Generic;
using System.Text;

namespace Section4BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node<T> Root;
        Node<T> Current;
        /// <summary>
        /// method for Inserting data in BST
        /// </summary>
        /// <param name="data"></param>
        public void InsertData(T data)
        {
            //Checking rootNode null or not.
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                return;
            }
            if (this.Current.data.CompareTo(data) > 0) //If data is less than data in root
                                                       //then current position node will be point to left.
            {
                if (this.Current.leftNode == null) //Checking left node is null or not.
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;
                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
            }
            else
            {
                if (this.Current.rightNode == null) // Checking right node is null or not.
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
            }
        }
        /// <summary>
        /// method for getting rootNode.
        /// </summary>
        /// <returns></returns>
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        /// <summary>
        /// method for displaying element or nodeData in bst
        /// </summary>
        /// <param name="node"></param>
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Element in BST tree is: " + node.data);
                Display(node.rightNode);
            }
        }
    }
}