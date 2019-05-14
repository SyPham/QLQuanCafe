using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Model.Model
{
    [Table("BillDetails")]
    public class BillDetail
    {
        [Key]
        public int BillDetailID { get; set; }
        public int ItemID { get; set; }
        public int BillID { get; set; }
        public int BonusID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public int Percent { get; set; }
    }
}
