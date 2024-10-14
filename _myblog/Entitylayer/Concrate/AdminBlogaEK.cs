using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
    public class AdminBlogaEK
    {
        [Key]
        public int AdminBlogEkID { get; set; }


        public string AdminBlogEkContent { get; set; }

        public string AdminBlogEkResim { get; set; }

        public string AdminBlogEkTitle { get; set; }
        public int BlogID { get; set; }
        public Blog BLogm { get; set; }
    }
}
