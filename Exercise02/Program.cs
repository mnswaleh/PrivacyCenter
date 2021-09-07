using Exercise01;
using System;
using System.Numerics;

namespace Exercise02
{
    static class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Input a number:");
                try
                {
                    string userInput = Console.ReadLine().Replace(",", "");
                    BigInteger input = BigInteger.Parse(userInput);
                    Console.WriteLine(input.Towards());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!");
                }
            } while (true);
        }
    }
}
