using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500, ErrorMessage = "Comments must not exceed 500 characters.")]
        public string? Comments { get; set; }

        [StringLength(500, ErrorMessage = "Suggestions must not exceed 500 characters.")]
        public string? Suggestions { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "User is required.")]
        public User? User { get; set; }
    }
}
