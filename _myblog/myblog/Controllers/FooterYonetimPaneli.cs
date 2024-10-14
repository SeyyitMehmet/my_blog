using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myblog.Controllers
{
    public class FooterYonetimPaneli : Controller
    {
        NavbarManager nm = new NavbarManager(new EfNavbarRepo());   
        public IActionResult hakkımda()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
