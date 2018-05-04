﻿namespace _09._Longer_Line
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double[] firstLine = GetLineCoordinates();
            double[] secondLine = GetLineCoordinates();
            PrintLineFromCenter(LongerLine(firstLine, secondLine));
        }

        private static void PrintLineFromCenter(double[] line)
        {
            double firstPointDistance = Math.Sqrt((line[0] * line[0]) + (line[1] * line[1]));
            double secondPointDistance = Math.Sqrt((line[2] * line[2]) + (line[3] * line[3]));
            Console.WriteLine((firstPointDistance > secondPointDistance) ? $"({line[2]}, {line[3]})({line[0]}, {line[1]})" : $"({line[0]}, {line[1]})({line[2]}, {line[3]})");
        }

        private static double[] LongerLine(double[] firstLine, double[] secondLine)
        {
            double firstLength = LineLength(firstLine);
            double secondLength = LineLength(secondLine);
            return (secondLength > firstLength) ? secondLine : firstLine;
        }

        private static double LineLength(double[] line)
        {
            return Math.Sqrt(((line[0] - line[2]) * (line[0] - line[2])) + ((line[1] - line[3]) * (line[1] - line[3])));
        }

        private static double[] GetLineCoordinates()
        {
            double[] line = new double[4];
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = double.Parse(Console.ReadLine());
            }

            return line;
        }
    }
}
