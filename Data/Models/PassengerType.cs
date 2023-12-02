using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class PassengerType
    {
        [Key]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(10, ErrorMessage = "Code must not exceed 10 characters.")]
        public string? Code { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        public TrainType? Type { get; set; }

        public string? Discount { get; set; }

        public List<Passenger>? Passengers { get; set; }
    }
}
