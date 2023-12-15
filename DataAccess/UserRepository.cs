using Models;
using Repositories;

namespace DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectContext _context;
        public UserRepository(ProjectContext context)
        {
            _context = context;
        }
    }
}
