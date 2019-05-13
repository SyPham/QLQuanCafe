using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Model.Model
{
    [Table("PermisionDetails")]
   public class PermisionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermisionDetailID { get; set; }
        public int PermisionID { get; set; }
        [StringLength(255)]
        public string ActionName { get; set; }
        [StringLength(255)]
        public string ActionCode { get; set; }
        public int CheckAciont { get; set; }
    }
}
