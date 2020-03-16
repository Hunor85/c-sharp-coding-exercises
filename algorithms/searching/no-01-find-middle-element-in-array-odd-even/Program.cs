using System;

namespace no_01_find_middle_element_in_array_odd_even
{
    class Program
    {
        public static void findMiddle(int[] nums)
        {
            int[] a;
            if (nums.Length % 2 == 0)
            {
                // even-length array (two middle elements)
                a = new int[2];
                a[0] = nums[(nums.Length / 2) - 1];
                a[1] = nums[nums.Length / 2];
            }
            else
            {
                // odd-length array (only one middle element)
                a = new int[1];
                a[0] = nums[nums.Length / 2];
            }

            // display the middle element
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        static void Main(string[] args)
        {
            // even-length array
            //int[] nums = { 1, 2, 3, 4 };

            // odd-length array
            int[] nums = { 1, 2, 3, 4, 5 };

            findMiddle(nums);
        }
    }
}
