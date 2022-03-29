#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuySaveFunction.Models;

    public class BuySaveFunctionContextDB : DbContext
    {
        public BuySaveFunctionContextDB (DbContextOptions<BuySaveFunctionContextDB> options)
            : base(options)
        {
        }

        public DbSet<BuySaveFunction.Models.Product> Products { get; set; }

        public DbSet<BuySaveFunction.Models.Review> Review { get; set; }

        public DbSet<BuySaveFunction.Models.User> User { get; set; }
    }
