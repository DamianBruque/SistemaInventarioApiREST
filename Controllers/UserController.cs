
using Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using DTO;
using Models;
using Microsoft.AspNetCore.Authorization;

namespace Controllers;

[ApiController]
[Route("/user")]
[Authorize]
public class UserController : ControllerBase
{
    private readonly IBaseService<UserEntity,UserDTO> baseService;
    public UserController(IBaseService<UserEntity,UserDTO> baseService)
    {
        this.baseService = baseService;
    }

    [Authorize(Roles = "ADMIN")]
    [HttpGet("all")]
    public IActionResult GetAll()
    {
        return Ok(baseService.GetAll());
    }

    [HttpGet("get")]
    public IActionResult Get(int id)
    {
        return Ok(baseService.GetById(id));
    }
    
}
