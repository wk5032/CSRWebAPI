using CSRWebAPI.Data;
using CSRWebAPI.Models;
using Library.API.Helpers;

namespace CSRWebAPI.Services
{
    public class LeaderBoardMockRepository : ILeaderBoardRepository
    {
        public bool IsLeaderBoardExists(ulong customerId)
        {
            return SCRMockData.Current.LeaderBoard.Any(l => l.customerId == customerId);
        }
        public IEnumerable<LeaderboardDto> RefreshLeaderboard()
        {
            var list = SCRMockData.Current.Customers.Where(c => c.Score > 0);
            var sortList = list.OrderByDescending(o => o.Score).ThenBy(t => t.customerId).ToList();
            int r = 0;
            var rankList = new List<LeaderboardDto>();
            rankList.Clear();
            foreach (var item in sortList)
            {
                r++;
                var leaderBoardItem = new LeaderboardDto();
                leaderBoardItem.customerId = item.customerId;
                leaderBoardItem.Score = item.Score;
                leaderBoardItem.Rank = r;
                rankList.Add(leaderBoardItem);
            }
            SCRMockData.Current.LeaderBoard.Clear();
            SCRMockData.Current.LeaderBoard = rankList;
            return SCRMockData.Current.LeaderBoard;
        }
        public IEnumerable<LeaderboardDto> GetLeaderboard()
        {
            return SCRMockData.Current.LeaderBoard; 
        }
        public IEnumerable<LeaderboardDto> GetCustomerByRank(ByRankParameters parameters)
        {
            return SCRMockData.Current.LeaderBoard.Where(lb => lb.Rank >= parameters.start && lb.Rank <= parameters.end);
        }
        public IEnumerable<LeaderboardDto>? GetCustomerByCustomerId(ulong customerId, ByCustomerIdParameters parameters)
        {
            var tLeadBoard = SCRMockData.Current.LeaderBoard.FirstOrDefault(lb => lb.customerId == customerId);
            if (tLeadBoard == null)
            {
                return null;
            }
            var rank = tLeadBoard.Rank;
            var high = rank - parameters.high;
            var low = rank + parameters.low;
            return SCRMockData.Current.LeaderBoard.Where(lb => lb.Rank >= high && lb.Rank <= low);
        }
    }
}
