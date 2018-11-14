using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        Node startingRoot;
        int Count;

        public void Add(Node newNode)
        {
            if (startingRoot == null)
            {
                startingRoot = newNode;
                Count++;
                return;
            }
            Node currentNode = startingRoot;

            while (currentNode != null)
            {
                if (newNode.data < currentNode.data)
                {
                    if (currentNode.leftChild == null)
                    {
                        currentNode.leftChild = newNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                    }
                }

                else if (newNode.data > currentNode.data)
                {
                    if (currentNode.rightChild == null)
                    {
                        currentNode.rightChild = newNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }

                }
            }
        }

        public bool Search(int number)
        {
            Node choosenNode = startingRoot;
            while (choosenNode != null)
            {
                if (number < choosenNode.data)
                {
                    choosenNode = choosenNode.leftChild;
                }
                else if (number > choosenNode.data)
                {
                    choosenNode = choosenNode.rightChild;
                }
                else if (number == choosenNode.data)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
