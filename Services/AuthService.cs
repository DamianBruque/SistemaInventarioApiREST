
using DTO;
using Services.Abstractions;

namespace Services;

public class AuthService : IAuthService
{
    private readonly IUserService userService;
    public AuthService(IUserService userService)
    {
        this.userService = userService;
    }
    public Task<UserDTO> Login(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<UserDTO> Register(UserDTO user, string password)
    {
        throw new NotImplementedException();
    }
}
