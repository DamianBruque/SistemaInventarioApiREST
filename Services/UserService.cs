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

        public async Task<UserDTO> Create(UserDTO user,string password)
        {
            var userEntity = Utilities.Map<UserEntity, UserDTO>(user);
            userEntity.Password = BCrypt.Net.BCrypt.HashPassword(password);
            userEntity.State = true;
            var result = await baseRepository.Create(userEntity);
            return Utilities.Map<UserDTO, UserEntity>(result);
        }

    }
}
