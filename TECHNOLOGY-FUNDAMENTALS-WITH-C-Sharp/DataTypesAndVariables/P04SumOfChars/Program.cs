using System;

namespace P04Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSymbols = int.Parse(Console.ReadLine());
            int sumOfChars = 0;


            for (int i = 0; i < numberOfSymbols; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sumOfChars += symbol;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
