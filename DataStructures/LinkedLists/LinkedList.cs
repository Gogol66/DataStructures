using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.DataStructures.LinkedLists
{
    public class Node
    {
        public object data;
        public Node next;
        public Node(object data)
        {
            this.data = data;
            next = null;
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
        public bool Remove(object data)
        {
            if (rootNode == null)
            {
                Console.WriteLine("The list is empty. Nothing to remove.");
                return false;
            }

            // Case: The rootNode node holds the data
            if (rootNode.data == data)
            {
                Console.WriteLine("Removing {0} from the rootNode of the list.", data);
                rootNode = rootNode.next;
                return true;
            }

            Node current = rootNode;
            while (current.next != null && current.next.data != data)
            {
                current.next = current.next.next;
            }

            current.next = current.next.next;
            return false;
        }

        public void Display()
        {
            Node currentNode = rootNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }
    }
}
