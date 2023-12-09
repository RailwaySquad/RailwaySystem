using Railway_Group01.Data;
using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Models.ViewModels
{
    public class ConfirmInformationViewModel
    {
        public List<PassengerDTO>? Passengers { get; set; }

        public List<CartDto>? Carts { get; set; }

        public User? User { get; set; }

        public decimal Total { get; set; }

        public List<CartJoinPassenger>? TicketList { get; set; }
    }

    public class CartJoinPassenger
    {
        public string? ID { get; set; }

        public string? Name { get; set; }

        public DateTime Birthday { get; set; }

        public string? PassengerType { get; set; }

        public int DiscountPercent { get; set; }
        public int SeatId { get; set; }

        public string? ScheduleName { get; set; }
        public string? Trip { get; set; }
        public string? StartAt { get; set; }
        public int CoachNo { get; set; }
        public int Cabin { get; set; }
        public int SeatNo { get; set; }
        public string? CoachClassName { get; set; }
        public decimal Price { get; set; }
    }
}
