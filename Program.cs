using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddFirst(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.Remove(30);
            list.Display();
            Console.ReadKey();
        }
    }
}
