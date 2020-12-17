using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abtract
{
    public abstract class Auditable:IAuditable
    {
       
      public  DateTime? CreatedDate { set; get; }
      [MaxLength(256)]
      public  string CreatedBy { set; get; }
      public  DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
       public  string UpdateBy { set; get; }
        // cac trien khai interface
        [MaxLength(256)]
        public string MetaKeyWord { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
