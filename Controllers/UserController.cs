
using Services;
using Microsoft.AspNetCore.Mvc;
using Models.DAO;

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
