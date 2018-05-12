namespace _04._Random_List
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var rl = new RandomList();
            Console.WriteLine(rl.RandomInteger());
            rl.Add("ggg");
            rl.Add(1);
            rl.Add("ttt");

            var test = rl[0]; 
            var test1 = rl[1];
        }
    }
}
