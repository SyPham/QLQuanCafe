using QLQuanCafe.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLQuanCafe.Model.Model
{
    [Table("Items")]
   public class Item: Auditalble
    {
        [Key]
        public int ID { get; set; }
        public int GroupItemID { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        [Column(TypeName ="xml")]
        public string Image { get; set; }
    }
}
