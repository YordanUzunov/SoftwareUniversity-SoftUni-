namespace _01._Convert_from_Base_10_to_Base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            BigInteger[] baseAndNumber = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            Console.WriteLine(NBaseNumber(baseAndNumber[0], baseAndNumber[1]));
        }

        private static string NBaseNumber(BigInteger targetBase, BigInteger tenBaseNumber)
        {
            StringBuilder sb = new StringBuilder();

            while (tenBaseNumber > 0)
            {
                int reminder = (int)BigInteger.Remainder(tenBaseNumber, targetBase);
                tenBaseNumber = BigInteger.Divide(tenBaseNumber, targetBase);
                sb.Insert(0, reminder);
            }

            return sb.ToString();
        }
    }
}
