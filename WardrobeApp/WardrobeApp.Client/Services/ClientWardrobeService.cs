using System.Net.Http.Json;
using WardrobeApp.Shared.Interfaces;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Client.Services;

public class ClientWardrobeService(HttpClient Http) : IWardrobeService
{
    public async Task AddClothingAsync(ClothingModel clothing)
    {
        await Http.PostAsJsonAsync<ClothingModel>("api/Wardrobe", clothing);
    }

    public async Task<List<ClothingModel>> GetWardrobeAsync()
    {
        return await Http.GetFromJsonAsync<List<ClothingModel>>("api/Wardobe") ?? new List<ClothingModel>();
    }
}
