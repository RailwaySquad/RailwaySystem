 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? PaymentId { get; set; }

        [StringLength(50, ErrorMessage = "Sender must not exceed 50 characters.")]
        public string? Sender { get; set; }

        [StringLength(50, ErrorMessage = "Receiver must not exceed 50 characters.")]
        public string? Receiver { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        public bool IsDone { get; set; }

        public DateTime CreatedAt { get; set; }

        public Booking? Booking { get; set; }

        public Cancelling? Cancelling { get; set; }
    }
}
