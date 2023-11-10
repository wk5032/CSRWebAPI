using CSRWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSRWebAPI.Controllers
{
    [Route("customers/{customerId}/scores")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ICustomerRepository customerRepository, ILeaderBoardRepository leaderBoardRepository)
        {
            CustomerRepository = customerRepository;
            LeaderBoardRepository = leaderBoardRepository;
        }
        public ICustomerRepository CustomerRepository { get; }
        public ILeaderBoardRepository LeaderBoardRepository { get; }

        [HttpPost("{score}", Name = nameof(UpdateScore))]
        public IActionResult UpdateScore(ulong customerId, int score)
        {
            if (Math.Abs(score) > 1000)
            {
                return BadRequest("The range of score is [-1000, 1000]" + " but it is " + score.ToString());
            }
            if (!CustomerRepository.IsCustomerExists(customerId))
            {
                return NotFound("Customer "+ customerId.ToString() + " didn't find.");
            }
            CustomerRepository.UpdateScore(customerId, score);
            LeaderBoardRepository.RefreshLeaderboard();

            var ascore = CustomerRepository.GetCustomerScore(customerId);
            return Ok(ascore);
        }
    }
}