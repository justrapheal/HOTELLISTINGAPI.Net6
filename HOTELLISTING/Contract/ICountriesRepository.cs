using HOTELLISTING.Data;

namespace HOTELLISTING.Contract
{
    public interface ICountriesRepository : IGenereicRepository<Country>
    {
        Task<Country> GetDetails(int id);

    }
}
