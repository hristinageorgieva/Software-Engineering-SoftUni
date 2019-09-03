using System;

namespace P05Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            for (char i = (char)start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
