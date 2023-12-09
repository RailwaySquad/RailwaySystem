using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Models
{
    public class PassengerDTO
    {
        public string? ID { get; set; }

        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public PassengerType? PassengerType { get; set; }

        public string? TypeCode { get; set; }

        public Ticket? Ticket { get; set; }
    }
}
