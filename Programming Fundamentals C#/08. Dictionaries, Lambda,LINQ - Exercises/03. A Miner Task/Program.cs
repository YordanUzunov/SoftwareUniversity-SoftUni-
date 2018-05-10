namespace _03._A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string res = Console.ReadLine();

            while (res != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(res))
                {
                    resources.Add(res, quantity);
                }
                else resources[res] += quantity;

                res = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
