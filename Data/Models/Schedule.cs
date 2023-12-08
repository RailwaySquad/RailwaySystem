using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Departure time is required.")]
        public DateTime Departure { get; set; }

        [Required(ErrorMessage = "Arrival time is required.")]
        public DateTime Arrival { get; set; }

        public bool IsFinished { get; set; } = false;

        [ForeignKey("TrainCode")]
        [Required(ErrorMessage = "Train is required.")]
        public Train? Train { get; set; }
        public string? TrainCode { get; set; }

        [ForeignKey("RouteId")]
        [Required(ErrorMessage = "Route is required.")]
        public Route? Route { get; set; }
        public int RouteId { get; set; }

        public List<Ticket>? Tickets { get; set; }
        public List<BookingDetail>? BookingDetails { get; set; }

    }
}
