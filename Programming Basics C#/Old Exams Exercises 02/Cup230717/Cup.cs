using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup230717
{
    class Cup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int dotsFirstRow = n;
            int hashFirstRow = width - 2 * n;
            int dotsSecondRow = n + n / 2;

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dotsFirstRow), new string('#', hashFirstRow));
                dotsFirstRow++;
                hashFirstRow -= 2;
            }
            int middleDots = width - 2 * (dotsSecondRow) - 2;
            for (int i = 0; i < (n+2)/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotsSecondRow), new string('#', 1), new string('.', middleDots));
                dotsSecondRow++;
                middleDots -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', (width - n)/2), new string('#', n));

            int finalHash = n + 4;
            int finalDots = (width - finalHash) / 2;
            int specialRow = n / 2 + 1;
            int row = 1;

            for (int i = 1; i <= n+2; i++)
            {
               
                if (row == specialRow)
                {
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.',(width - 10)/2));
                    row++;
                    continue;
                }
                Console.WriteLine("{0}{1}{0}", new string('.', finalDots), new string('#', finalHash));
                row++;
            }
            
        }
    }
}
