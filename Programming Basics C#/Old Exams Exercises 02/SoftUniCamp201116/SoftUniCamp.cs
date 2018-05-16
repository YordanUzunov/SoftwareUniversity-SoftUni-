using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp201116
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var grupi = double.Parse(Console.ReadLine());
            double kola = 0;
            double mikrobus = 0;
            double malakbus = 0;
            double golqmbus = 0;
            double vlak = 0;
            double totalStudents = 0;

            for (int i = 1; i <= grupi; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num <= 5) kola += num;
                if (num >= 6 && num <= 12) mikrobus += num;
                if (num >= 13 && num <= 25) malakbus += num;
                if (num >= 26 && num <= 40) golqmbus += num;
                if (num >= 41) vlak += num;
                totalStudents += num;
            }
            Console.WriteLine("{0:f2}%", ((kola/totalStudents) *100));
            Console.WriteLine("{0:f2}%", ((mikrobus / totalStudents) * 100));
            Console.WriteLine("{0:f2}%", ((malakbus / totalStudents) * 100));
            Console.WriteLine("{0:f2}%", ((golqmbus / totalStudents) * 100));
            Console.WriteLine("{0:f2}%", ((vlak / totalStudents) * 100));
        }
    }
}
