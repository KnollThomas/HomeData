using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace Infrastructure.Database
{
    public class TemperatureDb : DbContext, IApplicationDbContext
    {
        public DbSet<TemperatureRecord> Temperatures { get; set; }

        public TemperatureDb()
        {

        }

        public TemperatureDb(DbContextOptions<TemperatureDb> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<TemperatureRecord>();

            base.OnModelCreating(modelBuilder);
        }


    }
}
