using WhiteVilla_VillaAPI.Models.DTO;

namespace WhiteVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
            new VillaDTO() { Id = 1, Name = "FirstVilla", Occupancy = 1000, Sqft = 1},
            new VillaDTO() { Id = 2, Name = "SecondVilla", Occupancy = 2000, Sqft = 2}
        };
    }
}
