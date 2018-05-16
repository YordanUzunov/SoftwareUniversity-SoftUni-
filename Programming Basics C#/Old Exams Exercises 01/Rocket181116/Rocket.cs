using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket181116
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                    Console.Write(" "); Console.Write(new string('*', n));
                Console.Write(" |");
                Console.WriteLine();
            }

            //for (int row = 1; row <= n; row++)
            //{
            //    for (var col = 1; col <= n - row; col++)
            //        Console.Write(" ");
            //    Console.Write("*");
            //    for (int col = 1; col < row; col++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 1; row < n; row++)
            //{
            //    for (int col = 1; col < row + 1; col++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write("*");
            //    for (int col = 1; col >= row - 1 ; col--)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
