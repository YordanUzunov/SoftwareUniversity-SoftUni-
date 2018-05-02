namespace _07._Fruite_Shop
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (fruit.Equals("banana") || fruit.Equals("apple") || 
                fruit.Equals("orange") || fruit.Equals("grapefruit") || 
                fruit.Equals("kiwi") || fruit.Equals("pineapple") || fruit.Equals("grapes"))
            {
                if (dayOfWeek.Equals("saturday") || dayOfWeek.Equals("sunday"))
                {
                    if (fruit.Equals("banana")) Console.WriteLine("{0:f2}", quantity * 2.70);
                    else if (fruit.Equals("apple")) Console.WriteLine("{0:f2}", quantity * 1.25);
                    else if (fruit.Equals("orange")) Console.WriteLine("{0:f2}", quantity * 0.90);
                    else if (fruit.Equals("grapefruit")) Console.WriteLine("{0:f2}", quantity * 1.60);
                    else if (fruit.Equals("kiwi")) Console.WriteLine("{0:f2}", quantity * 3.00);
                    else if (fruit.Equals("pineapple")) Console.WriteLine("{0:f2}", quantity * 5.60);
                    else if (fruit.Equals("grapes")) Console.WriteLine("{0:f2}", quantity * 4.20);
                }
                else if (dayOfWeek.Equals("monday") || dayOfWeek.Equals("tuesday") || dayOfWeek.Equals("wednesday") || dayOfWeek.Equals("thursday") || dayOfWeek.Equals("friday"))
                {
                    if (fruit.Equals("banana")) Console.WriteLine("{0:f2}", quantity * 2.50);
                    else if (fruit.Equals("apple")) Console.WriteLine("{0:f2}", quantity * 1.20);
                    else if (fruit.Equals("orange")) Console.WriteLine("{0:f2}", quantity * 0.85);
                    else if (fruit.Equals("grapefruit")) Console.WriteLine("{0:f2}", quantity * 1.45);
                    else if (fruit.Equals("kiwi")) Console.WriteLine("{0:f2}", quantity * 2.70);
                    else if (fruit.Equals("pineapple")) Console.WriteLine("{0:f2}", quantity * 5.50);
                    else if (fruit.Equals("grapes")) Console.WriteLine("{0:f2}", quantity * 3.85);
                }
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
