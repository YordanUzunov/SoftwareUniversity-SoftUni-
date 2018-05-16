using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainersSalary180317
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            double lekcii = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double jelev = 0;
            double royal = 0;
            double roli = 0;
            double trofon = 0;
            double sino = 0;
            double others = 0;
            double salaryEach = budget / lekcii;

            for (int i = 1; i <= lekcii; i++)
            {
                var lektor = Console.ReadLine();
                if (lektor == "Jelev") jelev += salaryEach;
                else if (lektor == "RoYaL") royal += salaryEach;
                else if (lektor == "Roli") roli += salaryEach;
                else if (lektor == "Trofon") trofon += salaryEach;
                else if (lektor == "Sino") sino += salaryEach;
                else others += salaryEach;
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", jelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royal);
            Console.WriteLine("Roli salary: {0:f2} lv", roli);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofon);
            Console.WriteLine("Sino salary: {0:f2} lv", sino);
            Console.WriteLine("Others salary: {0:f2} lv", others);
        }
    }
}
