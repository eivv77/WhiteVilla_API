using WhiteVilla_VillaAPI.Models;
using WhiteVilla_VillaAPI.Models.DTO;

namespace WhiteVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string usernmame);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);

    }
}
