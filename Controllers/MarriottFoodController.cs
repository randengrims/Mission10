using FullStackFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {
        private BowlersDBContext _bowlersContext;
        public MarriottFoodController(BowlersDBContext temp)
        {
            _bowlersContext = temp;
        }
        [HttpGet(Name = "GetBowlers")]
        public IEnumerable<object>Get()
        {
            var bowlerList = _bowlersContext.Bowlers
                .Include(b => b.TeamName)
                .Where(b => b.TeamName != null && (b.TeamName.TeamName == "Marlins" || b.TeamName.TeamName == "Sharks"))
                .Select(b => new
                {
                    b.BowlerID,
                    BowlerName = string.Concat(
                        b.BowlerFirstName ?? "",
                        !string.IsNullOrEmpty(b.BowlerMiddleInit) ? " " + b.BowlerMiddleInit : "",
                        !string.IsNullOrEmpty(b.BowlerLastName) ? " " + b.BowlerLastName : ""
                        ).Trim(), // Ensures extra spaces are removed if middle/last name is missing
                    TeamName = b.TeamName != null ? b.TeamName.TeamName : "No Team Assigned",
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber
                })
                .ToList();

            return (bowlerList);
        }
    }
}
