using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class RouteDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("DepartureStationId")]
        public Station? DepartureStation { get; set; }
        public int DepartureStationId { get; set; }

        [Required]
        [ForeignKey("ArrivalStationId")]
        public Station? ArrivalStation { get; set; }
        public int ArrivalStationId { get; set; }

        [ForeignKey("RouteId")]
        [Required(ErrorMessage = "Route is required.")]
        public Route? Route { get; set; }
        public int RouteId { get; set; }

        [Required(ErrorMessage = "Distance is required.")]
        public int Distance { get; set; }

        [Required(ErrorMessage = "Travel Time is required.")]
        public int TravelTime { get; set; }

        public int DelayTime { get; set; }
    }
}
