using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Data
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public DateTime? StartAt { get; set; }
        [Required]
        public int ScheduleId { get; set; }
        [Required]  
        public int CoachId { get; set; }
        [Required]
        public int Seat { get; set; }
        [Required]
        public string CIDNo { get; set; }
        public DateTime CreateAt { get; set; }
        [ForeignKey("ScheduleId")]
        public Schedule? Schedule { get; set; }
        [ForeignKey("CoachId")]
        public Coach? Coach { get; set; }
        [ForeignKey("CIDNo")]
        public Passenger? Passenger { get; set; }
    }
}
