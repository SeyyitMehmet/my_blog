using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Entitylayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
    public class NavbarrList:ViewComponent
    {
        NavbarManager nm = new NavbarManager(new EfNavbarRepo());
        public IViewComponentResult Invoke()
        {

            var values = nm.GetList();
            //ViewBag.Data = values;
            return View(values);
        }
    }
}
