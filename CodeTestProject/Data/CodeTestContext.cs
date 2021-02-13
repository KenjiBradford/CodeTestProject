using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeTestProject.Models;

namespace CodeTestProject.Models
{
    public class CodeTestContext : DbContext
    {
        public CodeTestContext (DbContextOptions<CodeTestContext> options)
            : base(options)
        {
        }

        public DbSet<CodeTestProject.Models.Offer> Offer { get; set; }

        public DbSet<CodeTestProject.Models.Product> Product { get; set; }

        public DbSet<CodeTestProject.Models.OfferProduct> OfferProduct { get; set; }
    }
}
