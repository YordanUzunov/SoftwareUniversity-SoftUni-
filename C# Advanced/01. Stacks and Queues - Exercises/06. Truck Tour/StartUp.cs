﻿namespace _06._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                pumps.Enqueue(Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray());
            }

            var truckFuel = 0;
            var startIndex = 0;
            var loopBottom = pumps.Count;

            for (int i = 0; i <= loopBottom && startIndex < pumps.Count; i++)
            {
                var currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                truckFuel += currentPump[0] - currentPump[1];

                if (truckFuel < 0)
                {
                    startIndex = i + 1;
                    loopBottom += pumps.Count;
                    truckFuel = 0;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
