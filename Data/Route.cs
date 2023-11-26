using Railway_Group01.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StartStationId { get; set; }
        [ForeignKey("StartStationId")]
        public Station? StartStation { get; set; }
        [Required]
        public int EndStationId { get; set; }
        [ForeignKey("EndStationId")]
        public Station? EndStation { get; set; }
        [Range(0, int.MaxValue)]
        public int Distance { get; set; }
        public ICollection<RouteDetails>? RouteDetails { get; set; }
        public ICollection<Fare>? Fares { get; set; }
    }
}
