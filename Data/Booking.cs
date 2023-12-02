using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public User? User { get; set; }
        public DateTime BookAt { get; set; }
        public List<BookingDetails>? BookingDetails { get; set; }
        public List<Transaction>? Transactions { get; set; }
        public List<Refund>? Refunds { get; set; }
    }
}
