
using System.ComponentModel.DataAnnotations;

namespace ESun.Models
{
    public class Product
    {
        [Key]
        public int No { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal FeeRate { get; set; }
    }
}
