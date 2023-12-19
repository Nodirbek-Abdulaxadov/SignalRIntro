using ChatApp.Data;
using ChatApp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController(AppDbContext dbContext)
    : ControllerBase
{
    private readonly AppDbContext _dbContext = dbContext;

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUser request)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);
        if (user != null)
        {
            return BadRequest("Username already exists");
        }

        var newUser = new User
        {
            FullName = request.FullName,
            PhoneNumber = request.PhoneNumber,
            Password = request.Password
        };
        await _dbContext.Users.AddAsync(newUser);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUser request)
    {
        var user = await _dbContext.Users
                                   .FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);
        if (user == null)
        {
            return BadRequest("Invalid credentials");
        }

        if (user.Password != request.Password)
        {
            return BadRequest("Invalid credentials");
        }

        return Ok(user);
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _dbContext.Users.ToListAsync();
        return Ok(users);
    }
}