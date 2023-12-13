using Models;
using Repositories;

namespace DataAccess
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ProjectContext context) : base(context)
        {
        }
    }
}
