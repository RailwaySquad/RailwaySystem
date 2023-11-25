using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Train
    {
        [Key]
        public string? TrainCode { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public bool IsRunning { get; set; }
        public List<Schedule>? Schedules { get; set; }
        public List<Coach>? Coachs { get; set; }
        
    }
}
