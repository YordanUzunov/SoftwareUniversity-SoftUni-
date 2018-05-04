namespace _10._Centuries_to_Nanoseconds
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            BigInteger microseconds = new BigInteger(milliseconds * 1000);
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
