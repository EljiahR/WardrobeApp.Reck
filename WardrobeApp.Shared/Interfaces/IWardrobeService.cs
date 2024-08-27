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
        public List<ClothingModel> GetWardrobe();
        public void AddClothing(ClothingModel clothing);
    }
}
