using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class BookingDetails
    {
        [Key]
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string? PNRNo { get; set; }
        public Ticket? Ticket { get; set; }
        public Booking? Booking { get; set; }
    }
}
