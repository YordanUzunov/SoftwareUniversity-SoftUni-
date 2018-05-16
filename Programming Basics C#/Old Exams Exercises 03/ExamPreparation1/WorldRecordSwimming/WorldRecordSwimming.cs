using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldRecordSwimming
{
    class WorldRecordSwimming
    {
        static void Main(string[] args)
        {
            double srecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double histime = speed * distance;
            double adddist = Math.Floor(distance / 15);
            double addtime = adddist * 12.5;
            histime += addtime;
            double diff = Math.Abs(histime - srecord);

            if (histime >= srecord) Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", diff);
            else if (histime < srecord) Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", histime);
        }
    }
}
