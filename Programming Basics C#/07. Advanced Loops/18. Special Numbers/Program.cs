﻿namespace _18._Special_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
                            if (n % first == 0 && n % second == 0 && n % third == 0 && n % fourth == 0)
                                Console.Write("{0}{1}{2}{3} ", first, second, third, fourth);
                        }
                    }
                }
            }
        }
    }
}
