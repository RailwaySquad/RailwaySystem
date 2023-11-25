using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }
        public int CoachNo { get; set; }
        public string? Class { get; set; }
        public int NoOfCompartments { get; set; }
        public int NoOfSeats { get; set; }
        public string? AvailableSeats { get; set; }
        public string? Description { get; set; }
        public Train? Train { get; set; }
    }
}
