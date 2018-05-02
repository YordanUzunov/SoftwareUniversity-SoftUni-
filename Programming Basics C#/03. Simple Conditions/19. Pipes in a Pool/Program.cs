namespace _19._Pipes_in_a_Pool
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var poolVolume = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            double p1WaterDebit = pipe1 * hours;
            double p2WaterDebit = pipe2 * hours;
            double allWater = p1WaterDebit + p2WaterDebit;

            if (allWater > poolVolume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, allWater - poolVolume);
            }
            else
            {
                // All percentages should be whole numbers (without rounding).
                int persentagePool = (int)(allWater / poolVolume * 100);
                int percentageP1 = (int)(p1WaterDebit / allWater * 100);
                int percentageP2 = (int)(p2WaterDebit / allWater * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", persentagePool, percentageP1, percentageP2);
            }
        }
    }
}
