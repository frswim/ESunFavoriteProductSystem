
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESun.Models
{
    public class LikeList
    {
        [Key]
        public int SN { get; set; }
        public int ProductNo { get; set; }
        public int OrderNumber { get; set; }
        public string Account { get; set; }
        public decimal TotalFee { get; set; }
        public decimal TotalAmount { get; set; }
        public string UserID { get; set; }

        [ForeignKey("ProductNo")]
        public Product Product { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}
