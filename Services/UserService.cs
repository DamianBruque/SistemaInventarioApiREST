using Models.DAO;
using Models.Entities;
using Repositories;

namespace Services
{
    public class UserService
    {
        private readonly IUserRepository repository;
        public UserService(IUserRepository userRepository)
        {
            repository = userRepository;
        }
        public Task<List<UserDAO>> GetUsers()
        {
            List<UserEntity> users = repository.GetUsers();
            Task<List<UserDAO>> usersDAO = new Task<List<UserDAO>>(() =>
            {
                List<UserDAO> usersDAO = new List<UserDAO>();
                foreach (UserEntity user in users)
                {
                    usersDAO.Add(new UserDAO()
                    {
                        UserId = user.UserId,
                        UserName = user.UserName,
                        UserEmail = user.UserEmail
                    });
                }
                return usersDAO;
            });
            return usersDAO;
        }
    }
}
