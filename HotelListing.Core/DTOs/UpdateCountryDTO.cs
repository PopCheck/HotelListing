using System.Collections.Generic;

namespace HotelListing.Core.DTOs
{
    public class UpdateCountryDTO : CreateCountryDTO
    {
        public IList<CreateHotelDTO> Hotels { get; set; }
    }
}
