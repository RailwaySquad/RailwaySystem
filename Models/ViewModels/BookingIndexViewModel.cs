using Microsoft.AspNetCore.Mvc.Rendering;
using Railway_Group01.Data;

namespace Railway_Group01.Models.ViewModels
{
    public class BookingIndexViewModel
    {
        public User? User { get; set; }

        public List<CartDto>? Cart { get; set; }

        public List<SelectListItem>? PassengerTypes { get; set; }

    }
}
