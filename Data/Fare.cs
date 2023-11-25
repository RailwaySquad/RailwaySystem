using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Fare
    {
        [Key]
        public int Id { get; set; }
        public Route? Route { get; set; }
        public int DistanceFrom { get; set; }
        public int DistanceTo { get; set; }
        public string? TypeOfCoach { get; set; }
        public string? TypeOfTrain { get; set; }
        public decimal Price { get; set; }
    }
}
