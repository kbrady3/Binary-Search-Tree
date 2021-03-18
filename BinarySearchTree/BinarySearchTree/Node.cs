using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node
    {
        string SData { get; set; } // represents name
        int IData { get; set; }    // represents place on top ten list
        Node Left { get; set; }    // left child (left subtree)
        Node Right { get; set; }   // right child (right subtree)

        public Node() { }

        public Node(string sData, int iData)
        {
            SData = sData;
            IData = iData;
        }

        public void Insert(int position, string name)
        {
            if(position <= IData) //If position is less than or equal to IData (existing position), the new node will go on the left
            {
                if(Left == null) //If the left node is null
                {
                    Left = new Node(name, position); //Assign a node to Left using the provided position and name
                }
                else //If the left node is NOT null
                {
                    Left.Insert(position, name);
                }
            }
            else //Otherwise, the new node will go on the right
            {
                if (Right == null)
                {
                    Right = new Node(name, position);
                }
                else
                {
                    Right.Insert(position, name);
                }
            }
        }

        //public string Search(string name)
        //{
        //    if (name == SData)
        //    {
        //        return "Name: " + SData + ", Position: " + IData;
        //    }
        //    else if (name)
        //}
    }
}
