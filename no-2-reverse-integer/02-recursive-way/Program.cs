using System;

namespace _02_recursive_way
{
    class Program
    {
        static int rev_num = 0;
        static int base_pos = 1;

        static int reversDigits(int num)
        {
            if (num > 0)
            {
                reversDigits(num / 10);
                rev_num += (num % 10) * base_pos;
                base_pos *= 10;
            }
            return rev_num;
        }

        static void Main(string[] args)
        {
            int num = 4562;
            Console.WriteLine(reversDigits(num));
        }
    }
}
