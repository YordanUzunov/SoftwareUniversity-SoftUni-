﻿namespace SoftJail.DataProcessor
{

    using Data;
    using System;
    using System.Linq;

    public class Bonus
    {
        public static string ReleasePrisoner(SoftJailDbContext context, int prisonerId)
        {

            var prisoner = context.Prisoners.Find(prisonerId);

            var oldReleaseDate = prisoner.ReleaseDate;

            if (oldReleaseDate == null)
            {
                return $"Prisoner {prisoner.FullName} is sentenced to life";
            }
            else
            {
                prisoner.ReleaseDate = DateTime.Now;

                prisoner.CellId = null;

                context.SaveChanges();

                return $"Prisoner {prisoner.FullName} released";
            }

        }
    }
}