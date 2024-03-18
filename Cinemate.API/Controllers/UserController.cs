using Cinemate.API.Services.UserService;
using Cinemate.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Cinemate.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    // GET: api/User
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
    {
        try
        {
            // Retrieve all users
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error with error message if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // GET: api/User/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetUserById(int id)
    {
        try
        {
            // Retrieve a user by ID
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound(); // Return 404 if user is not found
            }
            return Ok(user);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error with error message if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // POST: api/User
    [HttpPost]
    public async Task<ActionResult<UserDto>> CreateUser(AddUserDto userDto)
    {
        try
        {
            // Create a new user
            var createdUser = await _userService.CreateUser(userDto);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error with error message if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // PUT: api/User/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, UserDto userDto)
    {
        try
        {
            // Update an existing user
            var updatedUser = await _userService.UpdateUser(id, userDto);
            if (updatedUser == null)
            {
                return NotFound(); // Return 404 if user is not found
            }
            return NoContent();
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error with error message if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // DELETE: api/User/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        try
        {
            // Delete a user by ID
            await _userService.DeleteUser(id);
            return Ok();
        }
        catch (Exception ex)
        {
            // Return 500 Internal Server Error with error message if an exception occurs
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
