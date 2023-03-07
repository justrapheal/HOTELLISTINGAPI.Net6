using AutoMapper;
using HOTELLISTING.Data;
using HOTELLISTING.Models.Country;
using HOTELLISTING.Models.Hotel;

namespace HOTELLISTING.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, GetCountryDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
