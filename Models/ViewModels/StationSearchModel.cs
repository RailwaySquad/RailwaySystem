using Railway_Group01.Data;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models.ViewModels
{
    public class StationSearchModel
    {
        public int? Station {  get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        [AllowNull]
        public List<Schedule>? Schedules { get; set; }
    }
}
