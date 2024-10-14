using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
	public class MenuList :ViewComponent
	{
		MenuManager mm =new MenuManager(new EfManuRepo());	
		public IViewComponentResult Invoke()
		{
			
			var values = mm.GetList();
			//ViewBag.Data = values;
			return View(values);
		}
	}
}
