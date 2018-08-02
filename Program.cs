using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 30, 20, 50, 40, 10 };
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }
            Console.WriteLine("Bubble Sorted array:");
            BubbleSort(a);
            Console.WriteLine("Selection Sorted array:");
            SelectionSort(a);
            Console.ReadKey();
            Console.WriteLine("Insertion Sorted array:");
            InsertionSort(a);
            Console.ReadKey();

        }
        static void BubbleSort(int[] arr)
        {
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int temp = arr[i];
                bool sorted = false;

                for (int j = i - 1; j >= 0 && !sorted; )
                {
                    if (temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        --j;
                        arr[j + 1] = temp;
                    }
                    else
                    {
                        sorted = true;
                    }
                }
            }
        }
    }
}


