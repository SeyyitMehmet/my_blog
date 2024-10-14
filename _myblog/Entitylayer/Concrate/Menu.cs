using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
	public class Menu
	{
		[Key]
		public int MenuID { get; set; }
		public string MenuTitle { get; set; }

		public string MenuKatagori { get; set; }

        public string  Content { get; set; }

    }
}
