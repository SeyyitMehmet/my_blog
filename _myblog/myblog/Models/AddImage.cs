namespace myblog.Models
{
    public class AddImage
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public IFormFile BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool Blogstatus { get; set; }
    }
}
