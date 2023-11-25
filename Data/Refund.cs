using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Refund
    {
        [Key]
        public int Id { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Booking? Booking { get; set; }
        public Transaction? Transaction { get; set; }
        public RefundRule? RefundRule { get; set; }
    }
}
