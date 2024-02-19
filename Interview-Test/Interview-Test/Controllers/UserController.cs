using Interview_Test.Models;
using Interview_Test.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Interview_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("GetUserById/{id}")]
    public ActionResult<User> GetUserById(string id)
    {
        var user = Data._users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return user;
    }
}