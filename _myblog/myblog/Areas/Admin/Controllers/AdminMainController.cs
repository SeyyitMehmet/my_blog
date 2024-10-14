using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using BusinessLayer.ValidationRules;
using DataAcsessLayer.Concrate;
using Entitylayer.Concrate;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using myblog.Controllers;
using myblog.Models;

namespace myblog.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
   
    public class AdminMainController : Controller
	{
        BlogManager bm = new BlogManager(new EfBlogRepository());
        MenuManager mm =new MenuManager(new EfManuRepo ());
        FooterManager fm= new FooterManager(new EfFooterRepo());
        NavbarManager nm = new NavbarManager(new EfNavbarRepo());   
        BlogEkManager bek= new BlogEkManager(new EfBlogEkRepo());   
        KullanicilarManager km = new KullanicilarManager(new EfKullanicilarRepo()); 
        public IActionResult AdminView()
		{
			return View();
		}
		public IActionResult yorumlar()
		{
			var values = bek.GetList();
			return View(values);
		}
		public IActionResult katagoriler()
		{
            var values = mm.GetList();
            return View(values);
        }
		public IActionResult CardDesing()
		{
			var values = bm.GetList();
			return View(values);
		}
        public IActionResult navbarIdare()
        {
            var values = nm.GetList();
            return View(values);
        }
		public IActionResult FooterIdare()
		{
			var values = fm.GetList();
			return View(values);
		}
		public IActionResult KullanicilarIdare()
		{
			var values = km.GetList();
			return View(values);
		}
        [HttpGet]
        public IActionResult KatagoriAdd()
        {

            return View();
        }
        [HttpPost]
        public IActionResult KatagoriAdd(Menu p, IFormFile ImageFile)
        {
          

            
            mm.AddT(p);


            return RedirectToAction("katagoriler", "AdminMain");
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p, IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                // Yeni bir dosya adı oluştur
                var newFileName = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);

                // Dosyayı diskte sakla
                //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BloggImage", newFileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/BloggImage/{newFileName}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                // Dosya yolu bilgisini model özelliğine ata
                p.BlogImage = $"BloggImage/{newFileName}";
            }

            // Diğer işlemleri yap

            // Veritabanına kaydetme işlemleri ve yönlendirme
            // ...
            p.Blogstatus = true;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToString());

            p.BlogThumbnailImage = "advghas";
            bm.AddT(p);
            
       
            return RedirectToAction("CardDesing", "AdminMain");
        }

		public IActionResult yorumDelete(int id)
		{
			var blogDelet = bek.GetById(id);
			bek.DeleteT(blogDelet);
			return RedirectToAction("yorumlar", "AdminMain");
		}
		public IActionResult KullaniciDelete(int id)
		{
			var kullaniciDelet = km.GetById(id);
			km.DeleteT(kullaniciDelet);
			return RedirectToAction("KullanicilarIdare", "AdminMain");
		}
		[HttpGet]
        public IActionResult yorumContentDesing(int id)
        {
            var yorumDesing = bek.GetById(id);
            return View(yorumDesing);
        }
        [HttpPost]
        public IActionResult yorumContentDesing(BlogEk p, IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                // Yeni bir dosya adı oluştur
                var newFileName = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);

                // Dosyayı diskte sakla
                //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BloggImage", newFileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/BloggImage/{newFileName}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                // Dosya yolu bilgisini model özelliğine ata
                p.BlogEkResim = $"/BloggImage/{newFileName}";
            }

            bek.UpdateT(p);
            return RedirectToAction("yorumlar", "AdminMain");
        }


        public IActionResult BlogDelete(int id)
        {
			var blogDelet =bm.GetById(id);
			bm.DeleteT(blogDelet);
            return RedirectToAction("CardDesing", "AdminMain");
        }
		[HttpGet]
        public IActionResult BlogContentDesing(int id)
		{
            
            var blogDesing= bm.GetById(id);
            //blogDesing.BlogImage= c.blogs.FirstOrDefault(x => x.BlogID == id).BlogImage;
           
            return View(blogDesing);
		}
		[HttpPost]
        public IActionResult BlogContentDesing(Blog p, IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                // Yeni bir dosya adı oluştur
                var newFileName = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);

                // Dosyayı diskte sakla
                //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BloggImage", newFileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/BloggImage/{newFileName}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                // Dosya yolu bilgisini model özelliğine ata
                p.BlogImage = $"/BloggImage/{newFileName}";
            }
            
			bm.UpdateT(p);


            return RedirectToAction("CardDesing", "AdminMain");
        }
        [HttpGet]
        public IActionResult yanMenuDesign(int id)
        {
            var katagoriDesing = mm.GetById(id);
            return View(katagoriDesing);

            
        }
		[HttpPost]
		public IActionResult yanMenuDesign(Menu p)
		{
            p.Content = Request.Form["Content"];

            mm.UpdateT(p);
            return RedirectToAction("katagoriler", "AdminMain");
          
        }
        public IActionResult MenuDelete(int id)
        {
            var katagoriDelet = mm.GetById(id);
            mm.DeleteT(katagoriDelet);
            return RedirectToAction("katagoriler", "AdminMain");
        }
        [HttpGet]
        public ActionResult NavbarDesign(int id)
        {
            var value = nm.GetById(id);
            return View(value);


		}
        [HttpPost]
		public ActionResult NavbarDesign(NavbarYonetimi p, IFormFile bigImg, IFormFile smallImg)
		{
			if (bigImg != null && bigImg.Length > 0)
			{
				// Yeni bir dosya adı oluştur
				var newFileName = Guid.NewGuid() + Path.GetExtension(bigImg.FileName);

				// Dosyayı diskte sakla
				//var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BloggImage", newFileName);
				var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/BloggImage/{newFileName}");
				using (var stream = new FileStream(filePath, FileMode.Create))
				{
                    bigImg.CopyTo(stream);
				}

				// Dosya yolu bilgisini model özelliğine ata
				p.BüyükResim = $"/BloggImage/{newFileName}";
               
			}
            if (smallImg != null && smallImg.Length > 0)
            {
                // Yeni bir dosya adı oluştur
                var newFileNamee = Guid.NewGuid() + Path.GetExtension(smallImg.FileName);

                // Dosyayı diskte sakla
                //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BloggImage", newFileName);
                var filePathh = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/BloggImage/{newFileNamee}");
                using (var streamm = new FileStream(filePathh, FileMode.Create))
                {
                    smallImg.CopyTo(streamm);
                }

                // Dosya yolu bilgisini model özelliğine ata
               
                p.KüçükResim = $"BloggImage/{newFileNamee}";
            }

            nm.UpdateT(p);
			return RedirectToAction("navbarIdare", "AdminMain");

		}
        [HttpGet]
        public ActionResult FooterDesign(int id)
        {
            var value = fm.GetById(id);
            return View(value);


        }
        public ActionResult FooterDesign(Footer p)
        {
            fm.UpdateT(p);
            return RedirectToAction("FooterIdare", "AdminMain");


        }

    }
}
