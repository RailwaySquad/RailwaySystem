using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Train
    {
        [Key]
		[Required]
		public string? TrainCode { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Type { get; set; }
		[Required]
		public string? Description { get; set; }
		[Required]
		public bool IsRunning { get; set; }
		public List<Schedule>? Schedules { get; set; }
        public List<Coach>? Coachs { get; set; }
        
    }
}
