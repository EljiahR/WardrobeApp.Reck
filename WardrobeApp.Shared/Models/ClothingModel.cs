using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeApp.Shared.Models;

public class ClothingModel
{
    public int Id { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string? Category { get; set; }
    public string? Description { get; set; }
    public byte[]? ImageData { get; set; }
    public string? ImageType { get; set; }
}
