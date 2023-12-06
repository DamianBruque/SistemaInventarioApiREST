
using Services;

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
    }
}
