using System;

namespace no_02_linear_search
{
    class Program
    {
        public static int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x) {
                    Console.WriteLine("Index: " + i + " Element: " + arr[i]);
                    return i;
                }              
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int x = 3;

            int result = search(arr, x);

            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
        }
    }
}
