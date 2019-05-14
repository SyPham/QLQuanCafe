using QLQuanCafe.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Model.Model
{
    [Table("Bills")]
   public class Bill :Auditalble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TableID { get; set; }
        public int UserID { get; set; }
        public double Total { get; set; }
        public double Reduce { get; set; }
        public double Pay { get; set; }
        public bool CancelTable { get; set; }
    }
}
