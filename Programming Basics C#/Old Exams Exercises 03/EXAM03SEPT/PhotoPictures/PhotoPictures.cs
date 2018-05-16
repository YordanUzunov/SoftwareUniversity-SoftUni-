using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPictures
{
    class PhotoPictures
    {
        static void Main(string[] args)
        {
            int brSnimki = int.Parse(Console.ReadLine());
            string vidSnimka = Console.ReadLine();
            string nachinPorychka = Console.ReadLine();

            double stoinost = 0.0;

            if (vidSnimka == "9X13")
            {
                stoinost = brSnimki * 0.16;
                if (brSnimki >= 50)
                {
                    stoinost = (brSnimki * 0.16) - ((brSnimki * 0.16) * 0.05);
                }
            }
            else if (vidSnimka == "10X15")
            {
                stoinost = brSnimki * 0.16;
                if (brSnimki >= 80)
                {
                    stoinost = (brSnimki * 0.16) - ((brSnimki * 0.16) * 0.03);
                }
            }
            else if (vidSnimka == "13X18")
            {
                stoinost = brSnimki * 0.38;
                if (brSnimki >= 50 && brSnimki <= 100)
                {
                    stoinost = (brSnimki * 0.38) - ((brSnimki * 0.38) * 0.03);
                }
                if (brSnimki > 100)
                {
                    stoinost = (brSnimki * 0.38) - ((brSnimki * 0.38) * 0.05);
                }

            }
            else if (vidSnimka == "20X30")
            {
                stoinost = brSnimki * 2.90;
                if (brSnimki >= 10 && brSnimki <= 50)
                {
                    stoinost = (brSnimki * 2.90) - ((brSnimki * 2.90) * 0.07);
                }
                if (brSnimki > 50)
                {
                    stoinost = (brSnimki * 2.90) - ((brSnimki * 2.90) * 0.09);
                }
            }
            if (nachinPorychka == "online")
            {
                stoinost = stoinost - stoinost * 0.02;
                Console.WriteLine("{0:f2}BGN", stoinost);
            }
            else
            {
                Console.WriteLine("{0:f2}BGN", stoinost);
            }
        }
    }
}
