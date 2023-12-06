using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models
{
    public class CartDto
    {
        [AllowNull]
        public string? Trip { get; set; }
        [AllowNull]
        public string? ScheduleName { get; set; }
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
        public int CoachNo { get; set; }
        public string? CoachClass { get; set; }
        public string? CoachClassName { get; set; }
        public int FromStation {  get; set; }
        public int ToStation { get; set; }

    }
}
