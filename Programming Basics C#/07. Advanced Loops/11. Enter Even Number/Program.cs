namespace _11._Enter_Even_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = 0;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    if (n != 0) break;
                }
                if (n % 2 == 0) break;
                else Console.WriteLine("The number is not even.");
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
