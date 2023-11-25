using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? NameOfDivision { get; set; }
        public string? Zone { get; set; }
        public string? ZipCode { get; set; }
    }
}
