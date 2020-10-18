using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace User.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("getUser")]
        public ActionResult<IEnumerable<string>> Get()
        {
            User user = GetDummyData();
            return Ok(user);
        }
        private User GetDummyData()
        {
            User user = new User
            {
                Id = 1,
                Name = "Awais Ilyas",
                Email = "im.awaisilyas@gmail.com"
            };
            return user;
        }
    }
}
