namespace _01._Action_Print
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            // Both variations are EQUAL
            Action<string[]> action = Print;
            action(input);

            // Both variations are EQUAL
            //Action<string[]> lambdaAction = arr => Console.WriteLine(string.Join(Environment.NewLine, arr));
            //lambdaAction(input);
        }

        public static void Print(string[] array)
        {
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
