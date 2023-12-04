using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models.ViewModels
{

    public class RailwaySearchModel
    {
        public int From { get; set; }
        public int To { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        [AllowNull]
        public List<Schedule>? Schedules { get; set; }
    }
}
