
using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace Controllers;

[ApiController]
[Route("/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService service;
    public AuthController(IAuthService authService)
    {
        service = authService;
    }

    [HttpPost("/login")]
    public IActionResult Login(string email, string password)
    {
        return Ok(service.Login(email, password));
    }

    [HttpPost("/register")]
    public IActionResult Register(UserDTO userDTO, string password)
    {
        return Ok(service.Register(userDTO, password));
    }
}
