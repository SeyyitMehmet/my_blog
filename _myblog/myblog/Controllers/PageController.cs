using Microsoft.AspNetCore.Mvc;

namespace myblog.Controllers
{
    public class PageController : Controller
    {
      
        public IActionResult page2()
        {
            return View();
        }
        public IActionResult page3()
        {
            return View();
        }
        public IActionResult page4()
        {
            return View();
        }
    }
}
