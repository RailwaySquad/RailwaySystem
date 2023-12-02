using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.DateTime)]
        public DateTime? Departure { get; set; }

        [Required(ErrorMessage = "Arrival time is required.")]
        [DataType(DataType.DateTime)]
        public DateTime? Arrival { get; set; }

        public bool IsFinished { get; set; }

        [Required(ErrorMessage = "Train is required.")]
        public Train? Train { get; set; }

        [Required(ErrorMessage = "Route is required.")]
        public Route? Route { get; set; }

        public List<Ticket>? Tickets { get; set; }
    }
}
