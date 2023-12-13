
using Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private readonly UserService service;
        public UserController(UserService userService)
        {
            service = userService;
        }
    }
}
