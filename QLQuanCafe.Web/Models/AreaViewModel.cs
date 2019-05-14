using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Web.Models
{
    public class AreaViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime? DateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdataBy { get; set; }
        public bool Status { get; set; }
    }
}