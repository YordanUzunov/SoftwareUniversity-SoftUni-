﻿namespace _04._Recharge.Models
{
    using Interfaces;

    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}