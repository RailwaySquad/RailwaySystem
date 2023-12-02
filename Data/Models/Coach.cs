using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CoachNo is required.")]
        public int CoachNo { get; set; }

        public int NoOfCompartments { get; set; } = 0;

        public int NoOfSeats { get; set; } = 0;

        [ForeignKey("ClassCode")]
        public CoachClass? Class { get; set; }
        public string? ClassCode { get; set; }
        [ForeignKey("TrainCode")]
        public Train? Train { get; set; }
        public string? TrainCode { get; set; }

        public List<Seat>? Seats { get; set; }
    }
}
