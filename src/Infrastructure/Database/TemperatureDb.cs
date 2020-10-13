using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Infrastructure.Database
{
    public class TemperatureDb : DbContext, IApplicationDbContext
    {
        public DbSet<TemperatureRecords> Temperatures { get; set; }


        public TemperatureDb()
            :base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[nameof(TemperatureDb)].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
