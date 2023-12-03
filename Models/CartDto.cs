using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models
{
    public class CartDto
    {
        [AllowNull]
        public string? Title { get; set; }
        [AllowNull]
        public DateTime? StartAt { get; set; }
        public int ScheduleId { get; set; }
        public int CoachId { get; set; }
        public int Seat {  get; set; }
        public int UserId { get; set; }
    }
}
