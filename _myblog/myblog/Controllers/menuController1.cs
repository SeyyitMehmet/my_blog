using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myblog.Controllers
{
	public class menuController1 : Controller
	{
		MenuManager mm=new MenuManager(new EfManuRepo());
		

		public IActionResult oyun(int id)
		{
            var value =mm.GetMenuByID(id);
            return View(value);
        }
		public IActionResult programlama()
		{
			return View();
		}
		public IActionResult algoritma()
		{
			return View();
		}
		public IActionResult Csharp ()
		{
			return View();
		}
		public IActionResult cPlus()
		{
			return View();
		}
		public IActionResult webtasarım()
		{
			return View();
		}
		public IActionResult bootsrap()
		{
			return View();
		}
		
		
	}
}
