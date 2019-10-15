using System;
using System.Linq;
using System.Collections.Generic;

namespace P09PokemonDontGo
{
    public class Program
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;

            while (sequence.Count != 0)
            {
                int indexes = int.Parse(Console.ReadLine());
                int firstElement = sequence[0];
                int lastElement = sequence[sequence.Count - 1];
                int valueToCompare = 0;

                if (indexes < 0)
                {
                    valueToCompare = sequence[0];
                    sequence.RemoveAt(0);
                    sequence.Insert(0, lastElement);
                }
                else if (indexes > sequence.Count - 1)
                {
                    valueToCompare = sequence[sequence.Count - 1];
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Add(firstElement);
                }
                else
                {
                    valueToCompare = sequence[indexes];
                    sequence.RemoveAt(indexes);
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    int currentValue = sequence[i];

                    if (currentValue <= valueToCompare)
                    {
                        sequence[i] = sequence[i] + valueToCompare;
                    }
                    else if (currentValue > valueToCompare)
                    {
                        sequence[i] = sequence[i] - valueToCompare;
                    }
                }

                sum += valueToCompare;
              
            }

            Console.WriteLine(sum);
        }
    }
}