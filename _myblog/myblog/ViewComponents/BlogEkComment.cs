using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Entitylayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using myblog.Controllers;
using System.Security.Claims;

namespace myblog.ViewComponents
{
	public class BlogEkComment:ViewComponent
	{
		
		
			BlogEkManager bem = new BlogEkManager(new EfBlogEkRepo());
			public IViewComponentResult Invoke(int id,BlogEk p,Kullanicilar p3)
			{
			//p.BlogEkTitle = ViewBag.mail2;

			string email = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

			var values = bem.GetBlogEkByID(id);
			//var values = bem.GetBlogEkAdminByID(id);
			
			//ViewBag.Data = values;
			return View(values);
			}
		
	}
}
