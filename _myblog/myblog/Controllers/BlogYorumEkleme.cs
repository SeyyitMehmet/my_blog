using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using DataAcsessLayer.Concrate;
using Entitylayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

public class Kullanicimm
{
	public string Ad { get; set; }
	public string Soyad { get; set; }
}
namespace myblog.Controllers
{
    [Authorize]

	
	public class BlogYorumEkleme : Controller
	{
		BlogEkManager bkManager = new BlogEkManager(new EfBlogEkRepo());

        [HttpGet]
        public PartialViewResult Index(int id)
        {
            ViewBag.deger = id;
            var value = bkManager.GetBlogEkByID(id);
            return PartialView(value);
        }


		[HttpPost]
		public IActionResult Index(BlogEk p, Kullanicimm y)
		{
		

			p.BlogEkResim = "http://www.tangoflooring.ca/wp-content/uploads/2015/07/user-avatar-placeholder.png";

	
	
			
				// userEmail değişkeni artık oturumdaki e-posta adresini içerir
				p.BlogEkTitle = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
			
			


			bkManager.AddT(p);

			return Json(new { success = true, message = "Yorum başarıyla eklendi" });
		}


	}
}
