namespace P05_KingsGambitExtended.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class SoldierList : List<IDefender>
    {
        public void HandleDeadSoldier(object sender, SoldierArgs args)
        {
            this.Remove(args.Soldier);
        }
    }
}
