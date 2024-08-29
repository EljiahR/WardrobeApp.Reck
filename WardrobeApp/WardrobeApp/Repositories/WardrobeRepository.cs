using Microsoft.EntityFrameworkCore;
using WardrobeApp.Data;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Repositories
{
    public class WardrobeRepository : IWardrobeRepository
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

        public async Task<ClothingModel> AddClothingAsync(ClothingModel clothing)
        {
            await _wardrobe.AddAsync(clothing);
            await SaveChangesAsync();
            return clothing;
        }

        public ClothingModel UpdateClothing(ClothingModel updatedClothing)
        {
            _wardrobe.Update(updatedClothing);
            SaveChanges();
            return updatedClothing;
        }

        public void DeleteClothing(ClothingModel clothing)
        {
            _wardrobe.Remove(clothing);
			SaveChanges();
        }

        private async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
