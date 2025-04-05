using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms
{
    public static class BinarySearch
    {
        public static void Search(int[] array, int element)
        {
            int lowerBound = 0;
            int upperBound = array.Length - 1;
            while (lowerBound <= upperBound)
            {
                int middle = (lowerBound + upperBound) / 2;
                if (array[middle] < element)
                {
                    lowerBound = middle + 1;
                }
                else if (array[middle] > element)
                {
                    upperBound = middle - 1;
                }
                else
                {
                    Console.WriteLine("The element is at index " + middle);
                    break;
                }
            }
        }
    }
}
