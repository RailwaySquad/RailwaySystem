﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Data
{
    public class Coach
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? TrainCode { get; set; }
        [ForeignKey("TrainCode")]
        public Train? Trains { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? TypeCode { get; set; }
        [Range(0, int.MaxValue)]
        public int NoOfCompartment { get; set; }
        [Range(0, int.MaxValue)]
        public int NoOfSeat { get; set; }
        [Range(0, int.MaxValue)]
        public int SeatAvailable { get; set; }
        [Required]
        public string? Description { get; set; }
        
    }
}
