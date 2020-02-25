using System;

namespace no_1_two_sum
{
    class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2) return null;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target) return new int[] { i, j };
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11 };
            int target = 9;
            TwoSum(nums, target);
        }
    }
}
