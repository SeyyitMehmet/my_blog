using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
	public class BlogEk
	{
        public int BlogEkID { get; set; }


		public string BlogEkContent { get; set; }

		public string BlogEkResim { get; set; }

		public string BlogEkTitle { get; set; }
        public int BlogID { get; set; }
        public Blog BLoggg { get; set; }
        public int KullaniciID { get; set; }
        public Kullanicilar kullanicim { get; set; }

    }
}
