using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            node.Insert(5, "William");
            node.Insert(1, "Noah");
            node.Insert(10, "Benjamin");
            node.Insert(8, "Alexander");
            node.Insert(9, "Michael");
            node.Insert(2, "Liam");
            node.Insert(3, "Mason");
            node.Insert(7, "James");
            node.Insert(6, "Ethan");
            node.Insert(4, "Jacob");
        }
    }
}
