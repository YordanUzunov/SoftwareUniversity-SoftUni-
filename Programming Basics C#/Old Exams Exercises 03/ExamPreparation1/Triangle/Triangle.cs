using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var weight = 4 * n + 1;
            var height = 2 * n + 1;
            Console.WriteLine(new string('#', weight));
            var white = 1;
            var dies = n * 2 - 1;
            for (int j = 1; j <= n; j++)
            {
                if (j == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', j), new string('#', dies), new string(' ', (white - 3) / 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', j), new string('#', dies), new string(' ', white));

                }
                white += 2;
                dies -= 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n + 1 + i), new string('#', 2 * n - 1 - 2 * i));
            }
        }
    }
}
