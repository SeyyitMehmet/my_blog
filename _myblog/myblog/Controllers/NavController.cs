using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myblog.Controllers
{
    public class NavController : Controller
    {
        NavbarManager nm = new NavbarManager(new EfNavbarRepo());
        public IActionResult hakkımda()
        {
            var values = nm.GetList();
            return View(values);
          
        }
        public IActionResult kurslar()
        {
            var values = nm.GetList();
            return View(values);
          
        }
        public IActionResult oyunlar()
        {
            var values = nm.GetList();
            return View(values);
        }
        public IActionResult websiteleri()
        {
            var values = nm.GetList();
            return View(values);
        }
        public IActionResult diger()
        {
            var values = nm.GetList();
            return View(values);
        }
      
    }
}
