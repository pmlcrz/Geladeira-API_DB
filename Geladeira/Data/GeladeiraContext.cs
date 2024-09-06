using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geladeira.Models;
using Microsoft.EntityFrameworkCore;

namespace Geladeira.Data
{
    public class GeladeiraContext : DbContext
    {
         public GeladeiraContext(DbContextOptions<GeladeiraContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
    }
}

