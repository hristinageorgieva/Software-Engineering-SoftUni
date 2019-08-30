﻿using System;

namespace P09PadawanEquipment
{
    class Program
    {
        static void Main()
        {
            decimal moneyAmount = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());

            int beltsCount = studentsCount - (studentsCount / 6);
            int lightsabersCount = studentsCount + (int)Math.Ceiling((studentsCount * 0.1m));

            decimal moneyNeeded = lightsabersPrice * lightsabersCount +
                robePrice * studentsCount +
                beltsPrice * beltsCount;

            decimal difference = Math.Abs(moneyAmount - moneyNeeded);

            if (moneyAmount >= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {difference:f2}lv more.");
            }
        }
    }
}
