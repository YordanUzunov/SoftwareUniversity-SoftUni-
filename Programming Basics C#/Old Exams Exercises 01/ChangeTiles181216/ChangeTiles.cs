using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles181216
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double pari = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double cena = double.Parse(Console.ReadLine());
            double suma = double.Parse(Console.ReadLine());

            double pod = width * length;
            double plochka = (a * ha) / 2;
            double nujniPlochki = Math.Ceiling(pod / plochka) +5;
            double obshtaSuma = nujniPlochki * cena + suma;

            if (obshtaSuma <= pari) Console.WriteLine("{0:f2} lv left.", (pari - obshtaSuma));
            else if (obshtaSuma > pari) Console.WriteLine("You'll need {0:f2} lv more.", (obshtaSuma - pari));
        }
    }
}
