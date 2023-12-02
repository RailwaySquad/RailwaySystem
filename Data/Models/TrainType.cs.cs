using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class TrainType
    {
        [Key]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(10, ErrorMessage = "Code must not exceed 10 characters.")]
        public string? Code { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters.")]
        public string? Name { get; set; }

        public List<Train>? Trains { get; set; }
        public List<Fare>? Fares { get; set; }
    }
}
