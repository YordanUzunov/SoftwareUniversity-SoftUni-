using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarships
{
    class Scolarships
    {
        static void Main(string[] args)
        {
            var dohod = double.Parse(Console.ReadLine());
            var uspeh = double.Parse(Console.ReadLine());
            var zaplataMin = double.Parse(Console.ReadLine());
            double scolarshipS = 0.0;
            double scolarshipE = 0.0;

            if (dohod > zaplataMin && uspeh < 5.5) Console.WriteLine("You cannot get a scholarship!");
            else if (dohod < zaplataMin && uspeh < 4.5) Console.WriteLine("You cannot get a scholarship!");
            else if (dohod >= zaplataMin && uspeh >= 5.5)
            {
                scolarshipE = Math.Floor(uspeh * 25);
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", scolarshipE);
            }
            else if (dohod < zaplataMin && uspeh >= 4.5 && uspeh < 5.5)
            {
                scolarshipS = Math.Floor(0.35 * zaplataMin);
                Console.WriteLine("You get a Social scholarship {0} BGN", scolarshipS);
            }
            else if (dohod < zaplataMin && uspeh >= 5.5)
            {
                scolarshipE = Math.Floor(uspeh * 25);
                scolarshipS = (0.35 * zaplataMin);
                if (scolarshipS > scolarshipE) Console.WriteLine("You get a Social scholarship {0} BGN", scolarshipS);
                else if (scolarshipE > scolarshipS) Console.WriteLine("You get a scholarship for excellent results {0} BGN", scolarshipE);
            }
        }
    }
}
