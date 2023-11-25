using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public Booking? Booking { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal Amount { get; set; }
        public string? PassengerName { get; set; }
    }
}
