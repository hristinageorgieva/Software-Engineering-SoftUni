using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P06Cards_Game
{
    class Program
    {
        public static void Main()
        {
            var firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            var count = 0;
            while (true)
            {
                if (firstPlayer[count] > secondPlayer[count])
                {
                    firstPlayer.Add(firstPlayer[count]);
                    firstPlayer.Add(secondPlayer[count]);
                    firstPlayer.RemoveAt(count);
                    secondPlayer.RemoveAt(count);
                }
                else if (firstPlayer[count] < secondPlayer[count])
                {
                    secondPlayer.Add(secondPlayer[count]);
                    secondPlayer.Add(firstPlayer[count]);
                    firstPlayer.RemoveAt(count);
                    secondPlayer.RemoveAt(count);
                }
                else
                {
                    firstPlayer.RemoveAt(count);
                    secondPlayer.RemoveAt(count);
                }
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }

            }
            if (firstPlayer.Sum() > secondPlayer.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}