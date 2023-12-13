using Repositories;
using Services.Abstractions;

namespace Services
{
    public class UserService : IUserService
    {
        
        private readonly IUserRepository repository;
        public UserService(IUserRepository userRepository)
        {
            repository = userRepository;
        }
    }
}
