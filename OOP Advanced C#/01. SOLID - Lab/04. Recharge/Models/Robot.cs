﻿namespace _04._Recharge.Models
{
    using Interfaces;

    public class Robot : Worker, IRechargeable
    {
        public Robot(string id, int capacity) : base(id)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; }

        public int CurrentPower { get; set; }

        public override void Work(int hours)
        {
            if (hours > this.CurrentPower)
            {
                hours = this.CurrentPower;
            }

            base.Work(hours);
            this.CurrentPower -= hours;
        }

        public void Recharge()
        {
            this.CurrentPower = this.Capacity;
        }
    }
}
