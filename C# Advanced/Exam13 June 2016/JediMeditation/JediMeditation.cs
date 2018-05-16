namespace JediMeditation
{
    using System;
    using System.Collections.Generic;

    public class JediMeditation
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> allJedis = new Queue<string>();
            Queue<string> masters = new Queue<string>();
            Queue<string> knights = new Queue<string>();
            Queue<string> padawans = new Queue<string>();
            Queue<string> toshoAndSlav = new Queue<string>();
            bool masterYodaIsHere = false;

            for (int i = 0; i < n; i++)
            {
                var jedis = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < jedis.Length; j++)
                {
                    if (jedis[j].StartsWith("m"))
                    {
                        masters.Enqueue(jedis[j]);
                    }
                    else if (jedis[j].StartsWith("k"))
                    {
                        knights.Enqueue(jedis[j]);
                    }
                    else if (jedis[j].StartsWith("p"))
                    {
                        padawans.Enqueue(jedis[j]);
                    }
                    else if (jedis[j].StartsWith("t"))
                    {
                        toshoAndSlav.Enqueue(jedis[j]);
                    }
                    else if (jedis[j].StartsWith("s"))
                    {
                        toshoAndSlav.Enqueue(jedis[j]);
                    }
                    else if (jedis[j].StartsWith("y"))
                    {
                        masterYodaIsHere = true;
                    }
                }
            }

            if (masterYodaIsHere)
            {
                foreach (var master in masters)
                {
                    allJedis.Enqueue(master);
                }
                foreach (var knight in knights)
                {
                    allJedis.Enqueue(knight);
                }
                foreach (var toshoOrSlav in toshoAndSlav)
                {
                    allJedis.Enqueue(toshoOrSlav);
                }
                foreach (var padawan in padawans)
                {
                    allJedis.Enqueue(padawan);
                }
            }
            else
            {
                foreach (var toshoOrSlav in toshoAndSlav)
                {
                    allJedis.Enqueue(toshoOrSlav);
                }
                foreach (var master in masters)
                {
                    allJedis.Enqueue(master);
                }
                foreach (var knight in knights)
                {
                    allJedis.Enqueue(knight);
                }
                foreach (var padawan in padawans)
                {
                    allJedis.Enqueue(padawan);
                }
            }
            Console.WriteLine(string.Join(" ", allJedis));
        }
    }
}
