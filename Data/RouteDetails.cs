using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class RouteDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DepartureStationId { get; set; }
        [ForeignKey("DepartureStationId")]
        public Station? DepartureStation { get; set; }
        [Required]
        public int ArrivalStationId { get; set; }
        [ForeignKey("ArrivalStationId")]
        public Station? ArrivalStation { get; set; }
        [Required]
        public int RouteId { get; set; }
        [ForeignKey("RouteId")]
        public Route? Route { get; set; }
        [Range(0, int.MaxValue)]
        public int Distance { get; set; }
        [Range(0, int.MaxValue)]
        public double TravelTime { get; set; }
        [Range(0, int.MaxValue)]
        public int DelayTime { get; set; }
    }
}
