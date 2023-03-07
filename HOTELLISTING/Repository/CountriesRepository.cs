using HOTELLISTING.Contract;
using HOTELLISTING.Data;
using Microsoft.EntityFrameworkCore;

namespace HOTELLISTING.Repository
{
    public class CountriesRepository : GenericRepositpry<Country>, ICountriesRepository
    {
        private readonly HotelListingDBContext _context;

        public CountriesRepository(HotelListingDBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
           return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);

        }
    }
}
  