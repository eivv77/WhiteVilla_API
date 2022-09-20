using System.ComponentModel.DataAnnotations;

namespace WhiteVilla_VillaAPI.Models.DTO
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }

    }
}
