using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Contact
    {
        [Key]
        public int ContacID { get; set; }
        
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMail { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        
        public string Message { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
