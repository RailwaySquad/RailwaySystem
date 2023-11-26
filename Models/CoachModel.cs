using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models
{
    public class CoachModel
    {
        public int Id { get; set; }
        public string? TrainCode { get; set; }
        public Train? Trains { get; set; }
        public string? Name { get; set; }
        public string? TypeCode { get; set; }
        [Range(0, int.MaxValue)]
        public int NoOfCompartment { get; set; }
        [Range(0, int.MaxValue)]
        public int NoOfSeat { get; set; }
        [Range(0, int.MaxValue)]
        public int SeatAvailable { get; set; }
        public string? Description { get; set; }
        [AllowNull]
        public int? CoachFare { get; set; }
    }
}
