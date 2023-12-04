﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class BookingDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Seat? Seat { get; set; }
        public int SeatId { get; set; }

        public Schedule? Schedule { get; set; }

        public Ticket? Ticket { get; set; }

        public Booking? Booking { get; set; }

    }
}