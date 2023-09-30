using System;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            bool isIdentical = false;
            int differenceIndex = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    isIdentical = true;
                    sum += arr1[i];
                }
                else
                {
                    differenceIndex = i;
                    isIdentical = false;
                    break;
                }
            }   
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differenceIndex} index");
            }
        }
    }
}