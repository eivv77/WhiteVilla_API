using System.ComponentModel.DataAnnotations;

namespace WhiteVilla_VillaAPI.Models.DTO
{
    public class VillaUpdateDTO
    {

        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; } //оценка
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int Sqft { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public string Amenity { get; set; } //удобства
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }





        //public DateTime CreatedTime { get; set; } =DateTime.UtcNow;

    }
}
