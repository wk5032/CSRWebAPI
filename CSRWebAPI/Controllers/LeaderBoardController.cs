using CSRWebAPI.Services;
using CSRWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Library.API.Helpers;

namespace CSRWebAPI.Controllers
{
    [Route("leaderboard")]
    [ApiController]
    public class LeaderBoardController : ControllerBase
    {
        public LeaderBoardController(ILeaderBoardRepository leaderboardRepository)
        {
            LeaderBoardRepository = leaderboardRepository;
        }
        public ILeaderBoardRepository LeaderBoardRepository { get; }

        [HttpGet()]
        public ActionResult<IEnumerable<LeaderboardDto>> GetCustomerByRank([FromQuery] ByRankParameters parameters)
        {
            return LeaderBoardRepository.GetCustomerByRank(parameters).ToList();
        }

        [HttpGet("{customerId}")]
        public ActionResult<IEnumerable<LeaderboardDto>> GetCustomerByCustomerId(ulong customerId, [FromQuery] ByCustomerIdParameters parameters)
        {
            return LeaderBoardRepository.GetCustomerByCustomerId(customerId, parameters).ToList();
        }
    }
}