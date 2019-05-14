using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Model.Model
{
    [Table("UserPermisions")]
   public class UserPermision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserPermisionID { get; set; }
        public int PermisionID { get; set; }
        public int UserID { get; set; }
        public int Licensed { get; set; }

    }
}
