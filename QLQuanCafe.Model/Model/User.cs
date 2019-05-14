using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLQuanCafe.Model.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public bool Status { get; set; }
        public DateTime? BirthDay { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        public string Mobi { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        public string CMND { get; set; }
        [MaxLength(100)]
        public string Username { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "xml")]
        public string Avatar { get; set; }
    }
}
