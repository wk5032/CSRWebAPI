
using System.ComponentModel.DataAnnotations;

namespace CSRWebAPI.Models
{
    public class CustomerDto
    {
        [Required]
        public ulong customerId { get; set; }
        public decimal Score { get; set; } = 0;

    }
}
