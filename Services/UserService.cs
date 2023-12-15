using DTO;
using Models;
using Repositories;
using Services.Abstractions;
using Utililies;

namespace Services
{
    public class UserService : IUserService
    {
        
        private readonly IUserRepository repository;
        private readonly IBaseRepository<UserEntity> baseRepository;
        public UserService(IUserRepository userRepository, IBaseRepository<UserEntity> baseRepository)
        {
            repository = userRepository;
            this.baseRepository = baseRepository;
        }

    }
}
