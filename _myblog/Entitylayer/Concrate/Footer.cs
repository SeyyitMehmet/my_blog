using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrate
{
    

    public class Footer
    {
        [Key]
        public int FooterID { get; set; }
        public string Awards { get; set; }

        public string Help { get; set; }
        public string Contact { get; set; }
        public string OzluSoz { get; set; }
        public string Facebook { get; set; }
        public string Google { get; set; }
        public string Instagram { get; set; }

    }
}
