using System.ComponentModel.DataAnnotations;

namespace Railway_Group01.Data
{
    public class RefundRule
    {
        [Key]
        public int Id { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public decimal MaxRefundAmount { get; set; }
    }
}
