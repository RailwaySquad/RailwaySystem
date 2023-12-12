using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class Ticket
    {
        [Key]
        [Required(ErrorMessage = "PNRNo is required.")]
        [StringLength(10, ErrorMessage = "PNRNo must not exceed 10 characters.")]
        public string? PNRNo { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public Fare? Fare { get; set; }

        public Schedule? Schedule { get; set; }

        [StringLength(20, ErrorMessage = "Passenger ID must not exceed 20 characters.")]
        public string? PassengerID { get; set; }
        public Passenger? Passenger { get; set; }

        public Cancelling? Cancelling { get; set; }

        public int BookingDetailId { get; set; }
        [Required]
        public BookingDetail? BookingDetail { get; set; }
    }
}
