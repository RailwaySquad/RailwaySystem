using Railway_Group01.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        public string? TypeCode { get; set; }
        public bool IsRunning { get; set; } = true;
        [AllowNull]
        public string? Description { get; set; }
        public ICollection<Schedule>? Schedules { get; set; }
        [ForeignKey("TrainCode")]
        public ICollection<Coach>? CoachesData {  get; set; }    
        public ICollection<CoachModel>? Coaches { get; set; }

        public override string ToString()
        {
            string print = $"Train {this.TrainCode}\nTypeCode: {this.TypeCode}\nName: {this.Name}\n";
            if (this.Schedules != null)
            {
                foreach (var item in this.Schedules)
                {
                    print += $"Schedule {item.RouteId}\n\t{item.StartAt}\n\t{item.EndAt}\n";
                }
            }
            else {
                print += "Schedules: Null\n"; 
            }
            if (this.CoachesData != null)
            {
                foreach (var item in this.CoachesData)
                {
                    print += $"Coachs: {item.Name}\n\t{item.TypeCode}\n";
                }
            }
            else {
                print += "Coaches: Null\n";
            }
            return print;
        }
    }
}
