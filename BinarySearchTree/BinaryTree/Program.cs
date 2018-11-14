using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
    
            static void Main(string[] args)
            {
                BinaryTree test = new BinaryTree();
                Node newNode = new Node(80);
                Node newNode1 = new Node(100);
                Node newNode2 = new Node(60);
                Node newNode3 = new Node(75);
                Node newNode4 = new Node(30);
                Node newNode5 = new Node(10);

                test.Add(newNode);
                test.Add(newNode1);
                test.Add(newNode2);
                test.Add(newNode3);
                test.Add(newNode4);
                test.Add(newNode5);
                test.Search(75);

                Console.WriteLine(test.Search(75));
                Console.ReadLine();
            }
        }
}
