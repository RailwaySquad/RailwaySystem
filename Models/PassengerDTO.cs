using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Models
{
    public class PassengerDTO
    {
        [Required]
        public string? ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public PassengerType? PassengerType { get; set; }

        public string? TypeCode { get; set; }

        public Ticket? Ticket { get; set; }

        public int DiscountPercent { get; set; }
        public int SeatId { get; set; }
    }
}
