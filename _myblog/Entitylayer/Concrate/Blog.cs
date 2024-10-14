using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entitylayer.Concrate
{
	public class Blog
	{
		[Key]
		public int BlogID { get; set; }
		public string BlogTitle { get; set; }
		public string BlogContent { get; set; }
		public string BlogThumbnailImage { get; set; }
		public string BlogImage { get; set; }
		public DateTime BlogCreateDate { get; set; }
		public bool Blogstatus { get; set; }
		public List<BlogEk> BlogEkkk { get; set;}

		
        //public bool menu { get; set; }

        //bağlantı için
        //public int katagoriID { get; set; }
        //public katagori katagori { get; set; }
        //public int writerID { get; set; }
        //public writer writer { get; set; }
        //public List<comment> comments { get; set; }
    }
}
