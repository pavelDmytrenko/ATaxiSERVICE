﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ATaxi.DL
{
    public class TaxiContext : DbContext, IDbContext
    {
        public TaxiContext(DbContextOptions<TaxiContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Order> Order { get; set; }

        public int SaveChange()
        {
            return SaveChanges();
        }
    }
}
