using CSRWebAPI.Data;
using CSRWebAPI.Models;

namespace CSRWebAPI.Services
{
    public class CustomerMockRepository : ICustomerRepository
    {
        public void UpdateScore(ulong customerId, int score)
        {
            var originalScore = GetCustomerScore(customerId);

            originalScore.customerId = customerId;
            originalScore.Score += score;
        }

        public CustomerDto? GetCustomerScore(ulong customerId)
        {
            return SCRMockData.Current.Customers.FirstOrDefault(b => b.customerId == customerId);
        }

        public bool IsCustomerExists(ulong customerId)
        {
            return SCRMockData.Current.Customers.Any(cus => cus.customerId == customerId);
        }
    }
}
