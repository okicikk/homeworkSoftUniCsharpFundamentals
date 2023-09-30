using System;
using System.Numerics;

namespace _01._Day_Of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = (Console.ReadLine());
            BigInteger day = default;
            if (char.IsDigit(command, 0))
            {
                day = BigInteger.Parse(command);
            }
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[(int)day - 1]);
            }
        }
    }
}