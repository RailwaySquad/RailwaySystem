using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }

        public bool Available { get; set; }
    }
}
