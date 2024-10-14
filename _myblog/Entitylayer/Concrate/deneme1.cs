using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
	
		public class deneme1
	{
		[Key]
		public int AdminID { get; set; }
		public string AdminPassword { get; set; }
		public string AdminMail { get; set; }
	}
}
