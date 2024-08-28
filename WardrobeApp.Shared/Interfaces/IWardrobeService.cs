using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Shared.Interfaces
{
    public interface IWardrobeService
    {
        public Task<List<ClothingModel>> GetWardrobeAsync();
        public Task<ClothingModel> AddClothingAsync(ClothingModel clothing);
    }
}
