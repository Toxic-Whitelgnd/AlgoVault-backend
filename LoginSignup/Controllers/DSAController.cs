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

        [HttpGet("getsolutionwithid")]
        public IActionResult GetSolutionwithID(int id)
        {
            try
            {
                List<DSAmodel> dsa = _db.DSATables.Where(x => x.Id == id).ToList();
                return Ok(dsa);
            }
            catch {
                return Ok("Error");
            }

        }

        [HttpPut("updatedsa")]
        public IActionResult UpdateDSA(DSAmodel d1)
        {
            _db.Update(d1);
            _db.SaveChanges();
            return Ok("Successful");
        }

        [HttpDelete("deletebyid")]
        public IActionResult DeleteDSA(int id) {
            try
            {
                DSAmodel d1 = _db.DSATables.FirstOrDefault(x => x.Id == id);
                _db.Remove(d1);
                _db.SaveChanges();
                return Ok("Deleted");
            }
            catch
            {
                return StatusCode(500);
            }
        }

    }
}
