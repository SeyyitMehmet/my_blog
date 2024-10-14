using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Entitylayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace myblog.Controllers
{
	
	public class cardController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		BlogEkManager bem = new BlogEkManager(new EfBlogEkRepo());
		public IActionResult bootstrapcard(int id)
		{

			
			ViewBag.i = id;
			var value = bm.GetBlogByID(id);
			
			return View(value);
		}
		
	}
}
