using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using DataAcsessLayer.Concrate;
using Entitylayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks; // Ekledik

namespace myblog.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class LoginController : Controller
	{
		AdminManager adminManager = new AdminManager(new EfAdminRepository());
		
		//[Authorize]
		

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(deneme1 p) // "async" ekledik
		{
			Context c = new Context();

			var values = await c.admins.FirstOrDefaultAsync(x => x.AdminMail == p.AdminMail && x.AdminPassword == p.AdminPassword); // "await" ekledik
			if (values != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.AdminMail)
				};
				var useridentity = new ClaimsIdentity(claims, "s");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("KullanicilarIdare", "AdminMain");
			}
			else
			{
				//return Redirect("/Admin/Login/Index");
				return RedirectToAction("Index", "Login");
			}
		}
	}
}
