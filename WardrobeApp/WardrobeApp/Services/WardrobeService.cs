using WardrobeApp.Repositories;
using WardrobeApp.Shared.Interfaces;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Services
{
    public class WardrobeService : IWardrobeService
    {
        private readonly IWardrobeRepository _wardrobeRepository;
        public WardrobeService(IWardrobeRepository wardrobeRepository)
        {
            _wardrobeRepository = wardrobeRepository;
        }

        public async Task<ClothingModel> AddClothingAsync(ClothingModel clothing)
        {
            return await _wardrobeRepository.AddClothingAsync(clothing);
        }

        public async Task<List<ClothingModel>> GetWardrobeAsync()
        {
            return await _wardrobeRepository.GetWardrobeAsync();
        }

        public void DeleteClothing(ClothingModel clothing)
        {
            _wardrobeRepository.DeleteClothing(clothing);
        }
    }
}
