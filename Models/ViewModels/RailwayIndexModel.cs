using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Railway_Group01.Models.ViewModels
{
    public class RailwayIndexModel
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        [AllowNull]
        public List<SelectListItem>? SelectListItems { get; set; }
        [AllowNull]
        public List<SelectListItem>? SelectListTrains { get; set; }
    }
}
