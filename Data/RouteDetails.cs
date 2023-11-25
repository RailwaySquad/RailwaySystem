using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class RouteDetails
    {
        [Key]
        public int Id { get; set; }
        public Station? DepartureStation { get; set; }
        public Station? ArrivalStation { get; set; }
        public Route? Route { get; set; }
        public int Distance { get; set; }
        public int TravelTime { get; set; }
        public int DelayTime { get; set; }
    }
}
