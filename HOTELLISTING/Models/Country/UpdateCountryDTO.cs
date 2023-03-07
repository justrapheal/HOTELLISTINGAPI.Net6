using System.ComponentModel.DataAnnotations;

namespace HOTELLISTING.Models.Country
{
    public class UpdateCountryDTO : BaseCountryDTO
    {
        [Required]
        public int Id { get; set; }
    }
  
}
