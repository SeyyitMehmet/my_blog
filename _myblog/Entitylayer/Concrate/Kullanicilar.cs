using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
    public class Kullanicilar
    {


        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciPassword { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciPhoto { get; set; }
        public List<BlogEk> BlogEkkkm { get; set; }


    }
}
