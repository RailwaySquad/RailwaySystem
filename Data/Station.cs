using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
		[Required]
		public string? Code { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? NameOfDivision { get; set; }
		[Required]
		public string? Zone { get; set; }
		[Required]
		public string? ZipCode { get; set; }
    }
}
