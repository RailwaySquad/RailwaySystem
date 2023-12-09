using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data 
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SeatNo { get; set; }
        public bool Available { get; set; } = false;
        public int CompartmentNo { get; set; } = 0;

        [ForeignKey("CoachId")]
        public Coach? Coach { get; set; }
        public int CoachId { get; set; }

        public BookingDetail? BookingDetail { get; set; }

        public List<Schedule>? Schedules { get; set; }
    }
}
