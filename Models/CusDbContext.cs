using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_FIrst.Models
{
    public class CusDbContext:DbContext
    { public CusDbContext(DbContextOptions<CusDbContext> options) : base(options) { }
        public DbSet<CustClass> custb { get; set; }
    }
}
