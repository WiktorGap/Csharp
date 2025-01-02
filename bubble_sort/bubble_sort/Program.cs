using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 31, 35 };
            int n = arr.Length;

            BubbleSort(arr, n);

            Console.WriteLine("Posortowana tablica:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void BubbleSort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
