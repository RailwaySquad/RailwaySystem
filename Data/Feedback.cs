using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Comments { get; set; }
        public string? Suggestions { get; set; }
        public int Rating { get; set; }
        public DateTime? CreatedAt { get; set; }
        public User? User { get; set; }
        public string? PNRNo { get; set; }
        public Ticket? Ticket { get; set; }
    }
}
