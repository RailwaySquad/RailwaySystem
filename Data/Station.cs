using Railway_Group01.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Data
{
    public class Station
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string? StationCode { get; set; }
        [Required]
        public string? StationName { get; set; }
        [AllowNull]
        public string? NameOfDivision { get; set; }
        [Required]
        public string? Zone { get; set; }
        public int? ZipCode { get; set; }
        public ICollection<Route>? StartRoutes { get; set; }
        public ICollection<Route>? EndRoutes { get; set; }
        public ICollection<RouteDetails>? DepartureRouteDetails { get; set; }
        public ICollection<RouteDetails>? ArrivalRouteDetails { get; set; }
    }
}
