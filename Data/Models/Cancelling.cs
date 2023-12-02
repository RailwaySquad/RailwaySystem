using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Cancelling
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255, ErrorMessage = "Receiver must not exceed 255 characters.")]
        public string? Reason { get; set; }

        public string? Sender { get; set; }

        public string? Receiver { get; set; }

        public DateTime? CreatedAt { get; set; }

        [Required]
        public RefundRule? RefundRule { get; set; }

        [Required]
        public User? User { get; set; }

        [Required]
        public string? PNRNo { get; set; }

        [Required]
        public Ticket? Ticket { get; set; }

        public List<Transaction>? Transactions { get; set; }
    }
}
