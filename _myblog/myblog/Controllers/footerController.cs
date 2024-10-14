using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace myblog.Controllers
{
	public class footerController : Controller
	{
        FooterManager nm = new FooterManager(new EfFooterRepo());
        public IActionResult aboutus()
		{
			return View();
		}
		public IActionResult products()
		{
			return View();
		}
		public IActionResult awards()
		{
            var values = nm.GetList();
            return View(values);
        }
		public IActionResult help()
		{
			

            var values = nm.GetList();
            return View(values);
        }
		public IActionResult contact()
		{
            var values = nm.GetList();
            return View(values);
        }
		public IActionResult sosyalmedia()
		{
            var values = nm.GetList();
            return View(values);
        }
	}
}
