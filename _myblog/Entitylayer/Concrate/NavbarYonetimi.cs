using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
    public class NavbarYonetimi
    {
        [Key]
        public int  NavbarID { get; set; }

        public string Hakkımda { get; set; }

        public string Kurslar { get; set; }

        public string Oyunlar { get; set; }
        public string Web { get; set; }

        public string Diger { get; set; }

        public string ResiminÜstYAzısı { get; set; }

        public string  BüyükResim { get; set; }

        public string KüçükResim { get; set; } 


    }
}
