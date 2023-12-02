using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
		[Required]
		public Station? StartStation { get; set; }
		[Required]
		public Station? EndStation { get; set; }
		[Required]
		public int Distance { get; set; }
        public List<RouteDetails>? RouteDetails { get; set; }
        public List<Schedule>? Schedules { get; set; }
        public List<Fare>? Fares { get; set; }
    }
}
