using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProject1.Models;

namespace WebProject1.Data
{
    public class WebProject1Context : DbContext
    {
        public WebProject1Context (DbContextOptions<WebProject1Context> options)
            : base(options)
        {
        }

        public DbSet<WebProject1.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
