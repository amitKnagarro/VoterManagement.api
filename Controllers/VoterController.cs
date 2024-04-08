using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoterManagement.api.Model;

namespace VoterManagement.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoterController : ControllerBase
    {
        public static List<Voters> voters = new List<Voters> ()
        {
            new Voters()
            {
                Id = 1,Name="Vikram",Ward="South", Age=23
            },
            new Voters()
            {
                Id = 2,Name="Namit",Ward="West", Age=43
            },
            new Voters()
            {
                Id = 3,Name="Akram",Ward="North", Age=34
            },
            new Voters()
            {
                Id = 4,Name="Snehil",Ward="East", Age=54
            },

        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok (voters);

        }
        [HttpPost]
        public IActionResult Post(Voters voter)
        {
            voters.Add(voter);
            return Ok (voters);
        }
        
    }
}
