using System;
using System.Collections.Generic;
using System.Text;

namespace Section4BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node<T> Root;
        Node<T> Current;
        public int ElementCount = 0;
        bool Result = false;
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
                ElementCount++;
                return;
            }
            if (this.Current.data.CompareTo(data) > 0) //If data is less than data in root
                                                       //then currentPosition node will be pointing to leftNode.
            {
                if (this.Current.leftNode == null) //Checking leftNode is null or not.
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;
                    ElementCount++;
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
                    ElementCount++;
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
        /// <summary>
        /// getting size of BSt
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return ElementCount;
        }
        /// <summary>
        /// method for searching data in BST
        /// </summary>
        /// <param name="data"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool SearchData(int data, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            else
            {
                if (this.Current.data.Equals(data)) //Checking for currentData equal to data or not.
                {
                    Result = true;
                }
                else if (this.Current.data.CompareTo(data) > 0) //If CurrentData is less than data in root then currentPosition of node
                                                                //will be pointing to leftNode otherwise rightNode
                {
                    this.Current = this.Current.leftNode;
                    SearchData(data, Current);
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    SearchData(data, Current);
                }
                return Result;
            }
        }
    }
}