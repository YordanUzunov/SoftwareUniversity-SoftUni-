using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation201116
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var pensii = double.Parse(Console.ReadLine());
            var uchenici = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            double grupa = pensii + uchenici;
            double cenaTrUch = 0;
            double cenaTrPen = 0;
            var noshtuvka = 82.99;

            if (transport == "train")
            {
                cenaTrUch = 14.99 * uchenici;
                cenaTrPen = 24.99 * pensii;
                if (grupa >= 50)
                {
                    cenaTrUch = (14.99 * uchenici) * 0.5;
                    cenaTrPen = (24.99 * pensii) * 0.5;
                }
            }
            else if (transport == "bus")
            {
                cenaTrUch = 28.50 * uchenici;
                cenaTrPen = 32.50 * pensii;
            }
            else if (transport == "boat")
            {
                cenaTrUch = 39.99 * uchenici;
                cenaTrPen = 42.99 * pensii;
            }
            else if (transport == "airplane")
            {
                cenaTrUch = 50.00 * uchenici;
                cenaTrPen = 70.00 * pensii;
            }
            double totalCena = ((cenaTrUch + cenaTrPen) * 2 + (noshtuvka * days)) * 1.1;
            Console.WriteLine("{0:f2}", totalCena);
        }
    }
}
