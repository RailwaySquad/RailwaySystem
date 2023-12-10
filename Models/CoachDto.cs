
using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models
{
    public class CoachDto
    {
        public int Id { get; set; }
        public int CoachNo { get; set; }

        public int NoOfCompartments { get; set; } = 0;

        public int NoOfSeats { get; set; } = 0;
        public CoachClass? Class { get; set; }
        public string? ClassCode { get; set; }

        public Train? Train { get; set; }
        public string? TrainCode { get; set; }

        public List<Seat>? Seats { get; set; }
        public int Price { get; set; } = 0;

    }
}
