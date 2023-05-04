using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Product : BaseEntity
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public double Stock { get; set; } = 0.0;
        public string LastSellDate { get; set; } = "";
        public string LastBuyDate { get; set; }
        public string Comment { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
