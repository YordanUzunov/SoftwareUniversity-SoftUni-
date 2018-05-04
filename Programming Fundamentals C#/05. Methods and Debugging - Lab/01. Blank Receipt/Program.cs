namespace _01._Blank_Receipt
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("{0}", '\u00A9');  // Copyright symbol
            PringBlackReceipt();
        }

        private static void PringBlackReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n" +
                            "\u00A9 SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\n" +
                            "Received by___________________");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n" +
                            "------------------------------");
        }
    }
}
