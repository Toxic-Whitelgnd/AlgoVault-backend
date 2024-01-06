using LoginSignup.Db;
using LoginSignup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginSignup.Controllers
{

    [Route("dsa/[controller]")]
    [ApiController]
    public class DSAController : ControllerBase
    {
        private readonly ApplicationDSADBcontext _db;

        public DSAController(ApplicationDSADBcontext db)
        {
            _db = db;
        }

        [HttpPost("dsadetails")]
        public IActionResult DsaDetails([FromBody] DSAmodel d1)
        {
            _db.Add(d1);
            _db.SaveChanges();
            return Ok(d1);
        }

        [HttpGet("getall")]
        public IActionResult GetAllDeatils(int userId)
        {
            try
            {
                List<DSAmodel> dataList = _db.DSATables.Where(x => x.UId == userId).ToList();
                return Ok(dataList);
            }
           catch
            {
                Console.WriteLine("No data for the current user");
            }

            return StatusCode(500);
        }
    }
}
