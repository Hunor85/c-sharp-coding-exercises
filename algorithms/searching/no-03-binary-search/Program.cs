using System;

namespace no_03_binary_search
{
    class Program
    {
        // iterative implementation
        static int binarySearch(int[] array, int x, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == x)
                    return mid;

                if (array[mid] < x) // x is on the right side
                    low = mid + 1;

                else
                    high = mid - 1;  // x is on the left side
            }
            return -1;
        }


        static void Main(string[] args)
        {
            int[] array = { 3, 4, 5, 6, 7, 8, 9 };
            int n = array.Length;
            int x = 4;
            int result = binarySearch(array, x, 0, n - 1);
            if (result == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("Element found at index " + result);  
        }
    }
}
