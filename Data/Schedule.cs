using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public bool IsCompleted { get; set; }
        public Route? Route { get; set; }
        public List<Ticket>? Tickets { get; set; }
    }
}
