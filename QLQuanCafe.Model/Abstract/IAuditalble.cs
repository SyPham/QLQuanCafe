using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Model.Abstract
{
    interface IAuditalble
    {
        DateTime? DateTime { get; set; }
        string CreateBy { get; set; }
        DateTime? CreateDate { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdataBy { get; set; }
        bool Status { get; set; }
    }
}
