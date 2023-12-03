using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class CoachClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Code { get; set; }
        public ICollection<Coach>? Coachs { get; set; }
    }
}
