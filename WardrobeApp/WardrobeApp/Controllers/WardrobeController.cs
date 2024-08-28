using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WardrobeApp.Data;
using WardrobeApp.Shared.Interfaces;
using WardrobeApp.Shared.Models;

namespace WardrobeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardrobeController : ControllerBase
    {
        private readonly IWardrobeService _wardrobeService;

        public WardrobeController(IWardrobeService wardrobeService)
        {
            _wardrobeService = wardrobeService;
        }

        // GET: api/Wardrobe
        [HttpGet]
        public async Task<ActionResult<List<ClothingModel>>> GetClothingModel()
        {
            return await _wardrobeService.GetWardrobeAsync();
        }

        // POST: api/Wardrobe
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClothingModel>> PostClothingModel(ClothingModel clothingModel)
        {
            await _wardrobeService.AddClothingAsync(clothingModel);

            return CreatedAtAction("GetClothingModel", new { id = clothingModel.Id }, clothingModel);
        }
    }
}
