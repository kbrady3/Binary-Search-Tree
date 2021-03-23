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
        List<string> namesList = new List<string>();

        public Node() { }

        public Node(string sData, int iData)
        {
            SData = sData;
            IData = iData;
        }

        public void Insert(int position, string name)
        {
            if (!namesList.Contains(name))
            {
                namesList.Add(name);
            }
            
            if (IData == 0)
            {
                IData = position;
            }
            if(SData == null)
            {
                SData = name;
            }
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

        public void DFS()
        {
            namesList.Sort();
            Console.WriteLine("Sorted list:" + "\n");
            foreach(string n in namesList)
            {
                Console.WriteLine(n);
            }
        }

        public string Search(string name)
        {
            if (name == SData)
            {
                return name;
            }
            else
            {
                string leftResult = "";
                string rightResult = "";

                try //Ensures Search method doesn't throw exception if null result returned
                {
                    leftResult = Left.Search(name); //Searches left side of tree, expecting an exception if it returns null
                    try
                    {
                        rightResult = Right.Search(name); //Provided Left.Search does not throw exception, search right side
                    }
                    catch
                    {
                    }
                }
                catch
                {
                    try
                    {
                        rightResult = Right.Search(name); //If Left.Search in "try" above throws an exception, it will jump directly here, where it will try searching the right side instead. No need to check left side because it was already checked in the above "try".
                    }
                    catch
                    {
                    }
                }

                if (leftResult == name)
                {
                    Console.WriteLine("Name: " + Left.SData + ", Position: " + Left.IData);
                    return "Name: " + Left.SData + ", Position: " + Left.IData;
                }
                else if (rightResult == name)
                {
                    Console.WriteLine("Name: " + Right.SData + ", Position: " + Right.IData);
                    return "Name: " + Right.SData + ", Position: " + Right.IData;
                }
                else
                {
                    return null;
                }
            }
        }

        public void InOrder(Node n)
        {
            if(Left != null)
            {
                InOrder(Left);
            }

            Console.WriteLine(IData);

            if(Right != null)
            {
                InOrder(Right);
            }
        }

        public void PreOrder(Node n)
        {
            Console.WriteLine(IData);

            if (Left != null)
            {
                InOrder(Left);
            }
            
            if (Right != null)
            {
                InOrder(Right);
            }
        }

        public void PostOrder(Node n)
        {
            if (Left != null)
            {
                InOrder(Left);
            }
            
            if (Right != null)
            {
                InOrder(Right);
            }

            Console.WriteLine(IData);
        }
    }
}