using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhiteVilla_VillaAPI.Models
{
    public class Villa
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } //id
        public string Name { get; set; } //imya
        public string Details { get; set; } //detali
        [Required]
        public double Rate { get; set; } //оценка
        public int Occupancy { get; set; } //аренда
        public int Sqft { get; set; } //квадратный фут
        public string ImgUrl { get; set; } //img
        public string Amenity { get; set; } //удобства
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
