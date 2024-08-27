﻿using Microsoft.EntityFrameworkCore;
using WardrobeApp.Data;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Repositories
{
    public class WardrobeRepository
    {

        private readonly WardrobeContext _context;
        private readonly DbSet<ClothingModel> _wardrobe;

        public WardrobeRepository(WardrobeContext context)
        {
            _context = context;
            _wardrobe = context.Set<ClothingModel>();
        }

        public async Task<List<ClothingModel>> GetWardrobeAsync()
        {
            return await _wardrobe.ToListAsync();
        }

        public async Task AddClothingAsync(ClothingModel clothing)
        {
            await _wardrobe.AddAsync(clothing);
            await SaveChangesAsync();
        }

        private async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
