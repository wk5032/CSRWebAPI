using CSRWebAPI.Models;

namespace CSRWebAPI.Data
{
    public class SCRMockData
    {
        public static SCRMockData Current { get; } = new SCRMockData();
        public List<CustomerDto> Customers { get; set; }
        public List<LeaderboardDto> LeaderBoard { get; set; }
        public SCRMockData()
        {
            Customers = new List<CustomerDto> {
                new CustomerDto {
                    customerId =15514665,
                    Score = 124 },
                new CustomerDto {
                    customerId =81546541,
                    Score = 113 },
                new CustomerDto {
                    customerId =1745431,
                    Score = 100 },
                new CustomerDto {
                    customerId =76786448,
                    Score = 100 },
                new CustomerDto {
                    customerId =254814111,
                    Score = 96 },
                new CustomerDto {
                    customerId =53274324,
                    Score = 95 },
                new CustomerDto {
                    customerId =6144320,
                    Score = 93 },
                new CustomerDto {
                    customerId =8009471,
                    Score = 93 },
                new CustomerDto {
                    customerId =11028481,
                    Score = 93 },
                new CustomerDto {
                    customerId =38819,
                    Score = 92 }
            };

            LeaderBoard = new List<LeaderboardDto> {
                new LeaderboardDto {
                    customerId =15514665,
                    Score = 124,
                    Rank = 1 },
                new LeaderboardDto {
                    customerId =81546541,
                    Score = 113, 
                    Rank = 2 },
                new LeaderboardDto {
                    customerId =1745431,
                    Score = 100,
                    Rank = 3 },
                new LeaderboardDto {
                    customerId =76786448,
                    Score = 100,
                    Rank = 4 },
                new LeaderboardDto {
                    customerId =254814111,
                    Score = 96,
                    Rank = 5 },
                new LeaderboardDto {
                    customerId =53274324,
                    Score = 95,
                    Rank = 6 },
                new LeaderboardDto {
                    customerId =6144320,
                    Score = 93,
                    Rank = 7 },
                new LeaderboardDto {
                    customerId =8009471,
                    Score = 93,
                    Rank = 8 },
                new LeaderboardDto {
                    customerId =11028481,
                    Score = 93,
                    Rank = 9 },
                new LeaderboardDto {
                    customerId =38819,
                    Score = 92,
                    Rank = 10 }
            };
        }
    }
}
