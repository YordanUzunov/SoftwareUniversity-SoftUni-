using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop181116
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            var magnolii = double.Parse(Console.ReadLine());
            var zumbili = double.Parse(Console.ReadLine());
            var rozi = double.Parse(Console.ReadLine());
            var kaktusi = double.Parse(Console.ReadLine());
            var podarakCena = double.Parse(Console.ReadLine());

            double porachka = (magnolii * 3.25 + zumbili * 4 + rozi * 3.50 + kaktusi * 8);
            double profit = porachka * 0.95;
            double diff = Math.Abs(profit - podarakCena);

            if (podarakCena > profit)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(diff));
            }
            else Console.WriteLine("She is left with {0} leva.", Math.Floor(diff));
        }
    }
}
