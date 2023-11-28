using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Fare
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RouteId { get; set; }
        [ForeignKey("RouteId")]
        public Route? Route { get; set; }
        [Required]
        public int DistanceRange { get; set; }
        [Required]
        public string? TypeOfClass { get; set; }
        [Required]
        public string? TypeOfTrain { get; set; }
        [Required]
        [Range(0, 100)]
        public double Price { get; set; }
    }
}
