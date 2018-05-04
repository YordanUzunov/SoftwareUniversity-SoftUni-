namespace _04._Draw_a_Filled_Square
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            DrawSquare(rows);
        }

        private static void DrawSquare(int rows)
        {
            PrintLine(rows * 2);
            for (int j = 0; j < rows - 2; j++)
            {
                Console.Write('-');
                for (int i = 0; i < rows - 1; i++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }

            PrintLine(rows * 2);
        }

        private static void PrintLine(int length)
        {
            Console.WriteLine(new string('-', length));
        }
    }
}
