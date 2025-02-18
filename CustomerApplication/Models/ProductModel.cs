using System.ComponentModel.DataAnnotations;

namespace CustomerApplication.Models
{
    public class ProductModel
    {
        [Required]
        [Range(1, 10000, ErrorMessage = "Order Amount must be between 1 and 1,00,000.")]

        public decimal OrderAmount { get; set; }
        public string? CustomerType { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
    }
}
