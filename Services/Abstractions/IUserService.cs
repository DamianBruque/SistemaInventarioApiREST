using DTO;

namespace Services.Abstractions
{
    public interface IUserService
    {
        public Task<UserDTO> Create(UserDTO user, string password);
    }
}
