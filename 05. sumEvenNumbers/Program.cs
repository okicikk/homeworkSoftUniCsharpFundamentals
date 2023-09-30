using System;
namespace _05._sumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = (Console.ReadLine().Split(' ') .Select(int.Parse) .ToArray());
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool isEven = input[i] % 2 == 0;
                if (isEven)
                {
                    sum += input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}