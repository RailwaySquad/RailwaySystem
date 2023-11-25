using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Passenger
    {
        [Key]
        public string? CIDNo { get; set; }
        public string? Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Gender { get; set; }
        public DateTime? TravelDate { get; set; }
        public User? User { get; set; }
        public Ticket? Ticket { get; set; }
    }
}
