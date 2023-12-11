using Models.Entities;

namespace Repositories
{
    public interface IUserRepository
    {
        List<UserEntity> GetUsers();
        UserEntity GetById(int id);
        UserEntity Create(UserEntity user);
        void Update(UserEntity user);
        void Delete(int id);

    }
}
