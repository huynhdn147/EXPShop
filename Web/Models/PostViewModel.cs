﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { set; get; }

        
        public string Name { set; get; }

        
        public string Alias { set; get; }

        
        public int CategoryID { set; get; }

    
        public string Image { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

      
        public virtual PostCategoryViewModel PostCategory { set; get; }

       
        public virtual IEnumerable<PostTagViewModel> posTags { set; get; }
        public DateTime? CreatedDate { set; get; }
        
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
      
        public string UpdateBy { set; get; }
        // cac trien khai interface
   
        public string MetaKeyWord { set; get; }
        
        public string MetaDescription { set; get; }
        public bool Status { set; get; }

    }
}