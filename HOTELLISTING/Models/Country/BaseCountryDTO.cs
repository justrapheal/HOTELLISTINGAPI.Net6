using Microsoft.Build.Framework;

namespace HOTELLISTING.Models.Country
{
    public abstract class BaseCountryDTO
    {
        [Required]
        public string Name { get; set; }
        public string ShortNaame { get; set; }
    }
}
