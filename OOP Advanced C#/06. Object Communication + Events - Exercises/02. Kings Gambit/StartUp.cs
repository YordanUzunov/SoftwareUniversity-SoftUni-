namespace E02_KingsGambit
{
    using P02_KingsGambit.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var king = new King(Console.ReadLine());
            var soldiers = new List<Soldier>();

            var guardsNames = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var footmenNames = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in guardsNames)
            {
                var royalGuard = new RoyalGuard(name);
                soldiers.Add(royalGuard);
                king.UnderAttack += royalGuard.KingUnderAttack;
            }
            foreach (var name in footmenNames)
            {
                var footman = new Footman(name);
                soldiers.Add(footman);
                king.UnderAttack += footman.KingUnderAttack;
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End") break;

                var commandArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandArgs[0];

                switch (command)
                {
                    case "Kill":
                        var soldierName = commandArgs[1];
                        var soldier = soldiers.FirstOrDefault(s => s.Name == soldierName);
                        king.UnderAttack -= soldier.KingUnderAttack;
                        soldiers.Remove(soldier);
                        break;
                    case "Attack":
                        king.OnAttack();
                        break;
                    default: break;
                }
            }
        }
    }
}