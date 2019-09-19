using System;

namespace P08Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber =long.Parse(Console.ReadLine());

            long firstNumberFactorial=GetFactorial(firstNumber);
            long secondNumberFactorial=GetFactorial(secondNumber);

            double finalResult = (double)firstNumberFactorial / secondNumberFactorial;

            Console.WriteLine($"{finalResult:f2}");
        }

        private static long GetFactorial(long number)
        {
            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
