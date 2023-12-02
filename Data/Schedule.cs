using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime? StartAt { get; set; }
		[Required]
		public DateTime? EndAt { get; set; }
        public bool IsCompleted { get; set; }
        public Train? Train { get; set; } 
        public Route? Route { get; set; }
        public List<Ticket>? Tickets { get; set; }
        [NotMapped] // Đánh dấu trường này không phải là một cột trong cơ sở dữ liệu
        public DayOfWeek? DayOfWeek => StartAt?.DayOfWeek;
    }
}
