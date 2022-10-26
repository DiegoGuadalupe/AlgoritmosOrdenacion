using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_de_ordenacion_reto_1
{
    internal class Program
    {
        static void sort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr ={ 20, 9, 23, 13, 6, 18, 25, 17, 4, 8, 15, 22, 16, 3, 24, 21, 14, 12, 1, 5, 7, 11,
19, 2, 10};
            Console.WriteLine("Array sin ordenar: ");
            printArray(arr);
            sort(arr);
            Console.WriteLine("Array ordenado: ");
            printArray(arr);
            Console.ReadKey();
        }
    }
}
