using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node boysNameTree = new Node();
            boysNameTree.Insert(5, "William");
            boysNameTree.Insert(1, "Noah");
            boysNameTree.Insert(10, "Benjamin");
            boysNameTree.Insert(8, "Alexander");
            boysNameTree.Insert(9, "Michael");
            boysNameTree.Insert(2, "Liam");
            boysNameTree.Insert(3, "Mason");
            boysNameTree.Insert(7, "James");
            boysNameTree.Insert(6, "Ethan");
            boysNameTree.Insert(4, "Jacob");
            Console.WriteLine(boysNameTree.Search("Noah"));
            Console.WriteLine(boysNameTree.Search("Liam"));
            Console.WriteLine(boysNameTree.Search("Ethan"));
            Console.WriteLine(boysNameTree.Search("Non-Existent Name"));
            Console.WriteLine(boysNameTree.Search("Kabrina"));
            boysNameTree.DFS();

            Node girlsNameTree = new Node();
            girlsNameTree.Insert(5, "Isabella");
            girlsNameTree.Insert(1, "Emma");
            girlsNameTree.Insert(10, "Harper");
            girlsNameTree.Insert(8, "Emily");
            girlsNameTree.Insert(9, "Charlotte");
            girlsNameTree.Insert(2, "Olivia");
            girlsNameTree.Insert(3, "Sophia");
            girlsNameTree.Insert(7, "Abigail");
            girlsNameTree.Insert(6, "Mia");
            girlsNameTree.Insert(4, "Ava");
            Console.WriteLine(girlsNameTree.Search("Ava"));
            Console.WriteLine(girlsNameTree.Search("Sophia"));
            Console.WriteLine(girlsNameTree.Search("Emma"));
            Console.WriteLine(girlsNameTree.Search("Non-Existent Name"));
            Console.WriteLine(girlsNameTree.Search("Kabrina"));
            girlsNameTree.DFS();
        }
    }
}
