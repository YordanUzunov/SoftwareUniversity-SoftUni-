namespace _11._Even_Odd_Positions
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            if (numbersCount <= 0)
            {
                Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No");
            }
            else if (numbersCount == 1)
            {
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=0, EvenMin=No, EvenMax=No", n);
            }
            else
            {
                double oddSum = double.Parse(Console.ReadLine());
                double oddMin = oddSum, oddMax = oddSum;
                double evenSum = double.Parse(Console.ReadLine());
                double evenMin = evenSum, evenMax = evenSum;

                for (int i = 3; i <= numbersCount; i++)
                {
                    double n = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenSum += n;
                        if (n < evenMin) evenMin = n;
                        else if (n > evenMax) evenMax = n;
                    }
                    else
                    {
                        oddSum += n;
                        if (n < oddMin) oddMin = n;
                        else if (n > oddMax) oddMax = n;
                    }
                }
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", 
                    oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
        }
    }
}
