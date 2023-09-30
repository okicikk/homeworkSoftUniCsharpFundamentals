using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] output = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {output[i]}");
            }
        }
    }
}