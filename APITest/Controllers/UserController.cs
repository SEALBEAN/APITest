using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    public class UserController : ControllerBase
    {
        //Write Login method here
        public UserController() { }

        [HttpPost(Name = "Login")]
        public Task<IActionResult> Login([FromBody] User user)
        {
            var user = await userService.LoginAsync(user);
            return Ok(user);
        }
    }
}
