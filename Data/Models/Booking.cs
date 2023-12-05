using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User is required.")]
        public User? User { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<BookingDetail>? BookingDetails { get; set; }

        public List<Transaction>? Transactions { get; set; }
    }
}
