using Microsoft.AspNetCore.Mvc.Rendering;
using Railway_Group01.Data;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models.ViewModels
{
    public class AdminTrainScheduleViewModel
    {
        [AllowNull]
        public List<Schedule>? Schedules { get; set; }
        public int SelectedMonth { get; set; } = DateTime.Now.Month;
        public int SelectedYear { get; set; } = DateTime.Now.Year;
    }
}
