using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Railway_Group01.Data
{
    public class RefundRule
    {
        [Key]
        public int Id { get; set; }

        public int ValidFrom { get; set; }

        public int ValidTo { get; set; }

        [Required(ErrorMessage = "Refund Amount is required.")]
        public int RefundAmount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal RefundFee { get; set; }

    }
}
