namespace _22._Smart_Lily
{
    using System;

    public class Program
    {
        public static void Main()
        {

            int ageOfLily = int.Parse(Console.ReadLine());
            double washmashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            for (int i = ageOfLily; i > 0; i--)
            {
                if (i % 2 != 0)
                    toys++;
            }
            toys *= toyPrice;

            int money = 0;
            for (int i = ageOfLily, m = 0; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    m += 10;
                    money += m;

                    money--;
                }
            }

            if (money + toys >= washmashinePrice)
                Console.WriteLine("Yes! {0:0.00}", Math.Round(money + toys - washmashinePrice, 2));
            else
                Console.WriteLine("No! {0:0.00}", Math.Round(washmashinePrice - (money + toys), 2));
        }
    }
}
