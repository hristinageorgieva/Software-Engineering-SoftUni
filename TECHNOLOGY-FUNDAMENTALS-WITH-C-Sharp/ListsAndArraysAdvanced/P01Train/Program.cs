using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacityOfWagon = int.Parse(Console.ReadLine);

            string command = Console.ReadLine();

            while (command!="end")
            {
                List<string> directions = command.Split().ToList();

                if (directions[0]=="Add") //Add 10 го делим на 2 части(то е лист от стринг с 2 индекса)
                {
                    int customersInWagon = int.Parse(directions[1]);
                    //това е втората част на стринга(пр. Add 10) с индекс[1] за да вземем числото само.

                    wagons.Add(customersInWagon);
                }
                else
                {
                    int passangerToFit = int.Parse(directions[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+passangerToFit<=capacityOfWagon)
                        {
                            wagons[i] += passangerToFit;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
