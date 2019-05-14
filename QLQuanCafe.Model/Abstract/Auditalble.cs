using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Model.Abstract
{
    public class Auditalble : IAuditalble
    {
        public DateTime? DateTime { get ; set; }
        [MaxLength(255)]
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(255)]
        public string UpdataBy { get; set; }
        public bool Status { get; set; }
    }
}
