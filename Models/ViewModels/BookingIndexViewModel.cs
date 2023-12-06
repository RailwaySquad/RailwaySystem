using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Railway_Group01.Models.ViewModels
{
    public class BookingIndexViewModel
    {
        public User? User { get; set; }

        public List<CartDto>? Cart { get; set; }

        public decimal Price { get; set; }
    }
}
