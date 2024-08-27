using WardrobeApp.Repositories;
using WardrobeApp.Shared.Interfaces;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Services
{
    public class WardrobeService : IWardrobeService
    {
        private readonly WardrobeRepository _wardrobeRepository;
        public WardrobeService(WardrobeRepository wardrobeRepository)
        {
            _wardrobeRepository = wardrobeRepository;
        }

        public async Task AddClothingAsync(ClothingModel clothing)
        {
            await _wardrobeRepository.AddClothingAsync(clothing);
        }

        public async Task<List<ClothingModel>> GetWardrobeAsync()
        {
            return await _wardrobeRepository.GetWardrobeAsync();
        }
    }
}
