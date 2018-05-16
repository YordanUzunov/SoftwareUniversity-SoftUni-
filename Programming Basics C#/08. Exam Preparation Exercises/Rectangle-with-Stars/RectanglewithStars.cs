using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_with_Stars
{
    class RectanglewithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstLastRow = new string('%', 2 * n);
            
            Console.WriteLine(firstLastRow);
            for (int i = 0; i < n - 2; i++)
            {
                if (n % 2 == 0)
                    if (i == n - 1)
                    {
                        Console.Write(new string('%', 1));
                        Console.Write(new string(' ', n - 2));
                        Console.Write("**");
                        Console.Write(new string(' ', n - 2));
                        Console.Write(new string('%', 1));
                    }
                    else Console.WriteLine(new string(' ', n - 2));
            }
            Console.WriteLine(firstLastRow);
        }
    }
}
