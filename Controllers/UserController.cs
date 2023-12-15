
using Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using DTO;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        private readonly IBaseService<UserEntity,UserDTO> baseService;
        public UserController(IUserService userService, IBaseService<UserEntity,UserDTO> baseService)
        {
            service = userService;
            this.baseService = baseService;
        }


        [HttpGet("/all")]
        public IActionResult GetAll()
        {
            return Ok(baseService.GetAll());
        }

        [HttpGet("/get")]
        public IActionResult Get(int id)
        {
            return Ok(baseService.GetById(id));
        }

        [HttpPost("/create")]
        public IActionResult Create(UserDTO user,string password)
        {
            return Ok(service.Create(user,password));
        }
        
    }
}
