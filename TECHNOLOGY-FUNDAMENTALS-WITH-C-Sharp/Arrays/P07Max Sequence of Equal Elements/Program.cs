﻿using System;
using System.Linq;

namespace P07MaxSequenceOfEqualElements
{
    public class StartUp
    {
        public static void Main()
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int start = 0;
            int bestStart = 0;
            int length = 0;
            int bestLength = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[start] == numbers[i])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    length = 0;
                }
            }
            for (int i = 0; i <= bestLength; i++)
            {
                Console.Write(numbers[bestStart + i] + " ");
            }
        }
    }
}
