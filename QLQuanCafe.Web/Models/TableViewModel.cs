using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Web.Models
{
    public class TableViewModel
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Name { get; set; }

        public DateTime? DateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdataBy { get; set; }
        public bool Status { get; set; }
        public virtual AreaViewModel Area { get; set; }
        public virtual IEnumerable<AreaViewModel> Areas { get; set; }
    }
}