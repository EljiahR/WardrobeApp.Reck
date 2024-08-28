using WardrobeApp.Shared.Models;

namespace WardrobeApp.Repositories
{
	public interface IWardrobeRepository
	{
		public Task<List<ClothingModel>> GetWardrobeAsync();
		public Task<ClothingModel> AddClothingAsync(ClothingModel clothing);
		public void DeleteClothing(ClothingModel clothing);
	}
}
