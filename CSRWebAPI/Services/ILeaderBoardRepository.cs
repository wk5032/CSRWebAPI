using CSRWebAPI.Models;
using Library.API.Helpers;

namespace CSRWebAPI.Services
{
    public interface ILeaderBoardRepository
    {
        bool IsLeaderBoardExists(ulong customerId);
        IEnumerable<LeaderboardDto> RefreshLeaderboard();
        IEnumerable<LeaderboardDto> GetLeaderboard();
        IEnumerable<LeaderboardDto> GetCustomerByRank(ByRankParameters parameters);
        IEnumerable<LeaderboardDto> GetCustomerByCustomerId(ulong customerId, ByCustomerIdParameters parameters);

    }
}
