using System.ComponentModel.DataAnnotations;

namespace CSRWebAPI.Models
{
    public class LeaderboardDto
    {
        [Required]
        public ulong customerId { get; set; }
        public decimal Score { get; set; } = 0;
        public Int32 Rank { get; set; }

    }
}
