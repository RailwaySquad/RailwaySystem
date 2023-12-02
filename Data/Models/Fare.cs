using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Fare
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public Route? Route { get; set; }

        public CoachClass? Class { get; set; }

        public TrainType? TrainType { get; set; }

        public List<Ticket>? Tickets { get; set; }
    }
}
