using Railway_Group01.Data;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models.ViewModels
{
    public class TrainSearchModel
    {
        public string? TrainCode { get; set; }
        [AllowNull]
        public DateTime StartDate { get; set; } = DateTime.Now;
        [AllowNull]
        public Schedule? TrainSchedule { get; set; }
        [AllowNull]
        public List<RouteDetail>? RouteDetails { get; set; } = new List<RouteDetail>();
    }
}
