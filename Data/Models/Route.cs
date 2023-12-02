using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data;

public class Route
{
    [Key]
    public int Id { get; set; }


    [Required]
    [ForeignKey("StartStationId")]
    public Station? StartStation { get; set; }
    public int StartStationId { get; set; }

    [Required]
    [ForeignKey("EndStationId")]
    public Station? EndStation { get; set; }
    public int EndStationId { get; set; }

    [Required(ErrorMessage = "Distance is required.")]
    public int Distance { get; set; }

    public List<RouteDetail>? RouteDetails { get; set; }

    public List<Schedule>? Schedules { get; set; }

    public List<Fare>? Fares { get; set; }
}
