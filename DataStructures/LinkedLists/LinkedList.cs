using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms
{
    public class Node
    {
        public object data;
        public Node next;
        public Node(object data)
        {
            this.data = data;
        }
    }
    class LinkedList
    {
        public Node rootNode;
        public LinkedList()
        {
            rootNode = null;
        }
        public void AddFirst(object data)
        {
            Node newNode = new Node(data);
            newNode.next = rootNode;
            rootNode = newNode;
        }
        public void AddLast(object data)
        {
            Node newNode = new Node(data);
            if (rootNode == null)
            {
                rootNode = newNode;
                return;
            }
            Node currentNode = rootNode;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = newNode;
        }
        public void Remove(object data)
        {
            if (rootNode == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            if (rootNode.data == data)
            {
                rootNode = rootNode.next;
                return;
            }
            Node currentNode = rootNode;
            while (currentNode.next != null && !currentNode.data.Equals(data))
            {
                currentNode = currentNode.next;
            }
            if (currentNode.next == null)
            {
                Console.WriteLine("Node with data not found");
            }
            else
            {
                currentNode.next = currentNode.next.next;
            }
        }
        public void Display()
        {
            Node currentNode = rootNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data + " ");
                currentNode = currentNode.next;
            }
        }
    }
}
