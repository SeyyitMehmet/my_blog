namespace myblog.Models
{
    public class UstResimler
    {
        public int NavbarID { get; set; }

        public string Hakkımda { get; set; }

        public string Kurslar { get; set; }

        public string Oyunlar { get; set; }
        public string Web { get; set; }

        public string Diger { get; set; }

        public string ResiminÜstYAzısı { get; set; }

        public IFormFile BüyükResim { get; set; }

        public IFormFile KüçükResim { get; set; }
    }
}
