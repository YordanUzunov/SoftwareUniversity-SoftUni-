﻿namespace PhotoShare.Services
{
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using AutoMapper.QueryableExtensions;

    using Models;
    using Contracts;
    using PhotoShare.Data;

    public class TownService : ITownService
    {
        private readonly PhotoShareContext context;

        public TownService(PhotoShareContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
                => this.By<TModel>(x => x.Id == id).SingleOrDefault();

        public TModel ByName<TModel>(string name)
                => this.By<TModel>(x => x.Name == name).SingleOrDefault();

        public bool Exists(int id)
                => this.ById<Town>(id) != null;

        public bool Exists(string name)
                => this.ByName<Town>(name) != null;

        public Town Add(string townName, string countryName)
        {
            var town = new Town
            {
                Name = townName,
                Country = countryName
            };

            this.context.Towns.Add(town);

            this.context.SaveChanges();

            return town;

        }

        private IEnumerable<TModel> By<TModel>(Func<Town, bool> predicate) =>
            this.context.Towns
                        .Where(predicate)
                        .AsQueryable()
                        .ProjectTo<TModel>();
    }
}
