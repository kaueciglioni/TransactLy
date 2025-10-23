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

        public DbSet<TransactLy.Web.Models.Department> Department { get; set; } = default!;
    }
}
