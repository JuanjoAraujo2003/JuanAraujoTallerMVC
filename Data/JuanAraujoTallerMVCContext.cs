using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanAraujoTallerMVC.Models;

namespace JuanAraujoTallerMVC.Data
{
    public class JuanAraujoTallerMVCContext : DbContext
    {
        public JuanAraujoTallerMVCContext (DbContextOptions<JuanAraujoTallerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JuanAraujoTallerMVC.Models.Burger> Burger { get; set; } = default!;
    }
}
