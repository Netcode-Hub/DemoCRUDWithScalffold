using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoCRUDWithScalffold.Models;

namespace DemoCRUDWithScalffold.Data
{
    public class DemoCRUDWithScalffoldContext : DbContext
    {
        public DemoCRUDWithScalffoldContext (DbContextOptions<DemoCRUDWithScalffoldContext> options)
            : base(options)
        {
        }

        public DbSet<DemoCRUDWithScalffold.Models.Product> Product { get; set; } = default!;
    }
}
