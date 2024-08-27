using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Data
{
    public class WardrobeContext : DbContext
    {
        public WardrobeContext (DbContextOptions<WardrobeContext> options)
            : base(options)
        {
        }

        public DbSet<WardrobeApp.Shared.Models.ClothingModel> ClothingModel { get; set; } = default!;
    }
}
