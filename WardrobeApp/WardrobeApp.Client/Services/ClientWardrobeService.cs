﻿using System.Net.Http.Json;
using WardrobeApp.Shared.Interfaces;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Client.Services;

public class ClientWardrobeService(HttpClient Http) : IWardrobeService
{
    public async Task<ClothingModel> AddClothingAsync(ClothingModel clothing)
    {
        var response = await Http.PostAsJsonAsync<ClothingModel>("api/Wardrobe", clothing);
        return await response.Content.ReadFromJsonAsync<ClothingModel>() ?? new ClothingModel();
    }

    public async Task<List<ClothingModel>> GetWardrobeAsync()
    {
        return await Http.GetFromJsonAsync<List<ClothingModel>>("api/Wardrobe") ?? new List<ClothingModel>();
    }
}
