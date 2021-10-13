using HotelListing.Models;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginDTO userDTO);
        Task<string> CreateToken();
    }
}
