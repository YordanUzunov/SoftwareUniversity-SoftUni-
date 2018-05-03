namespace _06._Strings_and_Objects
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";
            hello = hello + " " + world;
            string both = hello;
            Console.WriteLine(both);
        }
    }
}
