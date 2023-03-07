using HOTELLISTING.Models.Hotel;

namespace HOTELLISTING.Models.Country
{
    public class CountryDTO : BaseCountryDTO
    {
        public int Id { get; set; }
     
        public List<HotelDto> Hotels { get; set; }

    }

  
}
