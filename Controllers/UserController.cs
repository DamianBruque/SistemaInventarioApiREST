
using Services;
using Microsoft.AspNetCore.Mvc;
using Models.DAO;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        private readonly UserService service;
        public UserController(UserService userService)
        {
            service = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDAO>>> GetAll()
        {
            List<UserDAO> users = await service.GetUsers();
            return users;
        }
    }
}
