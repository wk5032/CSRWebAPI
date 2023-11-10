using CSRWebAPI.Models;

namespace CSRWebAPI.Services
{
    public interface ICustomerRepository
    {
        //IEnumerable<ScoreDto> GetScoreForCustomer(Int64 customerId);
        CustomerDto? GetCustomerScore(ulong customerId);
        void UpdateScore(ulong customerId, int score);
        bool IsCustomerExists(ulong customerId);
    }
}
