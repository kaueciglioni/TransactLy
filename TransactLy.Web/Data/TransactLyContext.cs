using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TransactLy.Web.Models;

namespace TransactLy.Data
{
    public class TransactLyContext : DbContext
    {
        public TransactLyContext (DbContextOptions<TransactLyContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SallesRecord> SallesRecord { get; set; } = default!;
    }
}
