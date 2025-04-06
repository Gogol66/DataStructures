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
            int[] array = { 10, 20, 30, 40, 50 };
            BinarySearch.Search(array, 40);
            int[] buffer = { 110, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            BubbleSort.Sort(buffer);
            foreach (var item in buffer)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
