using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit280816
{
    class Profit
    {
        static void Main(string[] args)
        {
            var rabotniDni = double.Parse(Console.ReadLine());
            var pariNaDen = double.Parse(Console.ReadLine());
            var kurs = double.Parse(Console.ReadLine());

            double mesecZaplata = rabotniDni * pariNaDen;
            double godishenDohod = mesecZaplata * 12 + mesecZaplata * 2.5;
            double danak = 0.25 * godishenDohod;
            double chistDohod = godishenDohod - danak;
            double levaDohod = chistDohod * kurs;
            double srednaPechalba = levaDohod / 365;
            Console.WriteLine("{0:f2}", srednaPechalba);
        }
    }
}
