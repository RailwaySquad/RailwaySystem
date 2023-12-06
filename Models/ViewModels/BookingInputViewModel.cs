using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Models.ViewModels
{
    public class BookingInputViewModel
    {
        [Required]
        public User? User { get; set; }
        public List<Passenger>? PassengerList { get; set; }

    }
}
