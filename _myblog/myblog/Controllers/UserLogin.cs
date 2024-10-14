using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using DataAcsessLayer.Concrate;
using Entitylayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace myblog.Controllers
{
	

	public class Kullanicilar2
	{
        public string mail2 { get; set; }
        public string password2 { get; set; }
		public string kullaniciiAdi { get; set; }
	}
    public class UserLogin : Controller

    {

		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		BlogEkManager bem =new BlogEkManager(new EfBlogEkRepo());	
		KullanicilarManager km = new KullanicilarManager(new EfKullanicilarRepo());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Index(Kullanicilar2 p2, Kullanicilar p,BlogEk p3, string tab)
		{
			bool kontrol1 = false;
			bool kontrol2 = false;

			Context c = new Context();

			if (tab == "Kaydol")
			{
				//Kullanıcının zaten var olup olmadığını kontrol edin
			   var mevcutKullanici = await c.kullanicilars.FirstOrDefaultAsync(x => x.KullaniciMail == p.KullaniciMail);
				if (mevcutKullanici != null)
				{
					ViewBag.ErrorMessage = "bu kullanıcı mailne adına sahip üyemiz var lütfen farklı mail kullanın";
					return View();
				}

				// Yeni kullanıcıyı veritabanına ekleyin

				//p.KullaniciPhoto = "dkfjsk";

				//bem.AddT(p3);
				// Gelen verilerin doğruluğunu kontrol et
				if (string.IsNullOrEmpty(p.KullaniciMail) || !IsValidEmail(p.KullaniciMail))
				{
					ModelState.AddModelError("KullaniciMail", "Geçerli bir e-posta adresi girin.");
				}

				if (string.IsNullOrEmpty(p.KullaniciPassword))
				{
					ModelState.AddModelError("KullaniciPassword", "Şifre boş bırakılamaz.");
				}

				if (string.IsNullOrEmpty(p.KullaniciPhoto))
				{
					ModelState.AddModelError("KullaniciPhoto", "Kullanıcı adı boş bırakılamaz.");
				}
				if (ModelState.IsValid)
				{
					// Tüm veriler geçerliyse kullanıcıyı kaydet
					// ...
					var claims = new List<Claim>
					{
						new Claim(ClaimTypes.Name,p.KullaniciPhoto)
					};
					var useridentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
					ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
					await HttpContext.SignInAsync(principal);

					km.AddT(p);
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ViewBag.ErrorMessage = "Bilgilerinizi boş gecemezsiniz lütfen doldurun";
					return View();
				}

			

			}
			else if (tab == "Giriş Yap")
			{
				if (string.IsNullOrEmpty(p2.mail2) || !IsValidEmail(p2.mail2))
				{
					ModelState.AddModelError("KullaniciMail", "Geçerli bir e-posta adresi girin.");
					 kontrol1 = true;
				}

				if (string.IsNullOrEmpty(p2.password2))
				{
					ModelState.AddModelError("KullaniciPassword", "Şifre boş bırakılamaz.");
					 kontrol2 = true;
				}
				if (kontrol1!=true&&kontrol2!=true)
				{

					var degerler = await c.kullanicilars.FirstOrDefaultAsync(x => x.KullaniciMail == p2.mail2 && x.KullaniciPassword == p2.password2);

					if (degerler != null)
					{

						var claims = new List<Claim> { new Claim(ClaimTypes.Name, degerler.KullaniciPhoto) };

						var useridentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
						ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
						await HttpContext.SignInAsync(principal);





						return RedirectToAction("Index", "Home");
					}
					else
					{
						ViewBag.ErrorMessage = "mail veya şifre hatalı";
						return View();
					}

				}
				else
				{
					ViewBag.ErrorMessage = "Bilgilerinizi boş gecemezsiniz lütfen doldurun";
					return View();
				}
			

			}

			return View();
		}

	}
}
