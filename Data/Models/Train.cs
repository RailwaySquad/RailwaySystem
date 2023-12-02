using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Train
    {
        [Key]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(10, ErrorMessage = "Code must not exceed 10 characters.")]
        public string? Code { get; set; }

        [ForeignKey("TypeCode")]
        public TrainType? Type { get; set; }
        public string? TypeCode { get; set; }

        public bool IsRunning { get; set; }

        public List<Schedule>? Schedules { get; set; }

        public List<Coach>? Coaches { get; set; }
    }
}
