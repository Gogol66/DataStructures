using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort");
            int[] array = { 5, 3, 8, 4, 2 };
            Console.WriteLine("Original array : ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SelectionSort(array);
            Console.WriteLine("Sorted array : ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Insertion Sort");
            int[] array1 = { 5, 3, 8, 4, 2 };
            Console.WriteLine("Original array : ");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            InsertionSort(array1);
            Console.WriteLine("Sorted array : ");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Quick Sort");
            int[] array2 = { 5, 3, 8, 4, 2 };
            Console.WriteLine("Original array : ");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            QuickSort(array2, 0, array2.Length - 1);
            Console.WriteLine("Sorted array : ");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                if (minIndex != i)
                {
                    T temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
        public static void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                T value = array[i];
                int hole = i;
                while (hole > 0 && array[hole - 1].CompareTo(value) > 0)
                {
                    array[hole] = array[hole - 1];
                    hole = hole - 1;
                }
                array[hole] = value;
            }
        }
        public static void QuickSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    QuickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(array, pivot + 1, right);
                }
            }
        }
        public static int Partition<T>(T[] array, int lower, int upper) where T : IComparable<T>
        {
            int i = lower;
            int j = upper;
            T pivot = array[(lower + upper) / 2];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }
        public static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}