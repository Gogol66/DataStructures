using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Search
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int element)
        {
            int left = 0;
            int middle = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (array[middle] == element)
                    return middle;
                else
                if (element < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
    }
}
