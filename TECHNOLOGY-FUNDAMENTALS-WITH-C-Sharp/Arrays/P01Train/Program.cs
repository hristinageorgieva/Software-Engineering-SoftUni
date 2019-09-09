using System;

namespace P01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            string allElements = String.Empty;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                allElements += currentNumber + " ";
            }
            Console.WriteLine(allElements.Trim());
            Console.WriteLine(sum);
        
        }
    }
}
