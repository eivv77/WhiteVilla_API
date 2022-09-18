using System.ComponentModel.DataAnnotations;

namespace WhiteVilla_VillaAPI.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; } //оценка 
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string ImgUrl { get; set; }
        public string Amenity { get; set; } //удобства
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }





        //public DateTime CreatedTime { get; set; } =DateTime.UtcNow;

    }
}
