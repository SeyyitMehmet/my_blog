using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using myblog.Models;
using System.Diagnostics;
using X.PagedList;

namespace myblog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BlogManager bm =new BlogManager(new EfBlogRepository());    
        MenuManager mm =new MenuManager(new EfManuRepo());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page=1)
        {
			var activeBlogs = bm.GetList().Where(x => x.Blogstatus).OrderByDescending(x => x.BlogID).ToPagedList(page, 6);
            int total = activeBlogs.Count();
			ViewBag.kontrol = 1;
            ViewBag.sayfa = total;

			return View(activeBlogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}