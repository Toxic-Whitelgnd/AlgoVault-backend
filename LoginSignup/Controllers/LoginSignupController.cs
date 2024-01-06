using LoginSignup.Db;
using LoginSignup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginSignup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginSignupController : ControllerBase
    {
        private readonly ApplicationDBcontext _db;
        public LoginSignupController(ApplicationDBcontext db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody]UserModel u1)
        {
            _db.Add(u1);
            _db.SaveChanges();
            return Ok(u1);
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login(string email, string password)
        {
            UserModel u1 = _db.userdetails.FirstOrDefault(x => x.Password == password && x.Email == email);
            if(u1 != null)
            {
                Console.WriteLine("Login Successfull:"+u1.Name);
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
            return Ok(u1);
        }
    }
}