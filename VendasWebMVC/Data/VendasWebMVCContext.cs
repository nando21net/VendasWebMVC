using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasWebMVC.Models;

namespace VendasWebMVC.Data
{
    public class VendasWebMVCContext : DbContext
    {
        public VendasWebMVCContext (DbContextOptions<VendasWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<VendasWebMVC.Models.Departamento> Departamento { get; set; }
        public DbSet<VendasWebMVC.Models.Vendedor> Vendedor { get; set; }
        public DbSet<VendasWebMVC.Models.Vendas> Vendas { get; set; }
    }
}
