using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class RefundRule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ValidFrom { get; set; }

        [Required]
        public int ValidTo { get; set; }

        [Required(ErrorMessage = "Refund Amount is required.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal RefundAmount { get; set; }

    }
}
