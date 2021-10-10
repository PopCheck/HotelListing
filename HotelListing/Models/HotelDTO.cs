using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class HotelDTO : CreateCountryDTO
    {
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
    }
}
