namespace _04._Fruit_or_Vegetable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string product = Console.ReadLine().ToLower();
            if (product.Equals("banana") || product.Equals("apple") || 
                product.Equals("kiwi") || product.Equals("cherry") || 
                product.Equals("lemon") || product.Equals("grapes"))
                Console.WriteLine("fruit");
            else if (product.Equals("tomato") || product.Equals("cucumber") || 
                product.Equals("pepper") || product.Equals("carrot"))
                Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}
