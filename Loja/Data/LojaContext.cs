using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Loja.Models
{
    public class LojaContext : DbContext
    {
        public LojaContext (DbContextOptions<LojaContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SalesRecords> SalesRecords{ get; set; }
    }
}
