using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models
{
    public class CartDto
    {
        [AllowNull]
        public string? Title { get; set; }
        [AllowNull]
        public string? StartAt { get; set; }
        [AllowNull]
        public string? SeatDetail { get; set; }
        public int ScheduleId { get; set; }
        public int CoachId { get; set; }
        public int Seat {  get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Cabin {  get; set; }
        public int CoachCount { get; set; }
        public int FromStation {  get; set; }
        public int ToStation { get; set; }

    }
}
