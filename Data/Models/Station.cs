using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Station
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required.")]
        [StringLength(10, ErrorMessage = "Code must not exceed 10 characters.")]
        public string? Code { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters.")]
        public string? Name { get; set; }
        [Required]
        public string? NameOfDivision { get; set; }
        [Required(ErrorMessage = "Name is required .")]
        public int Zone { get; set; }
		[Required(ErrorMessage = "Zipcode is required.")]
		public int ZipCode { get; set; }

        public ICollection<Route>? StartRoutes { get; set; }
        public ICollection<Route>? EndRoutes { get; set; }

        public ICollection<RouteDetail>? DepartureRouteDetails { get; set; }
        public ICollection<RouteDetail>? ArrivalRouteDetails { get; set; }
    }
}
