using System;

namespace RunningSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] nums = new int[4] { 1, 2, 3, 4 };
            int[] result = RunningSum(nums);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                result[i] = sum;
            }
            return result;
        }
    }
}
