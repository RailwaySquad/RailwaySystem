using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Passenger
    {
        [Key]
        [StringLength(20, ErrorMessage = "ID must not exceed 20 characters.")]
        public string? ID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters.")]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [ForeignKey("TypeCode")]
        public PassengerType? PassengerType { get; set; }
        public string? TypeCode { get; set; }

        public Ticket? Ticket { get; set; }

    }
}
