using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Ticket
    {
        [Key]
        public string? PNRNo { get; set; }
        public decimal Price { get; set; }
        public int CompartmentNo { get; set; }
        public int SeatNo { get; set; }
        public string? Status { get; set; } // sold, cancelled, done
        public Schedule? Schedule { get; set; }
        public Coach? Coach { get; set; }
        public string? CIDNo { get; set; }
        public Passenger? Passenger { get; set; }
        public Feedback? Feedback { get; set; }
        public BookingDetails? BookingDetails { get; set; }
    }
}
