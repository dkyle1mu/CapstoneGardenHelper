using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garden_Helper_Site.Models;

namespace Garden_Helper_Site.Data
{
    public class Garden_Helper_SiteContext : DbContext
    {
        public Garden_Helper_SiteContext (DbContextOptions<Garden_Helper_SiteContext> options)
            : base(options)
        {
        }

        public DbSet<Garden_Helper_Site.Models.Plant> Plant { get; set; } = default!;
    }
}
