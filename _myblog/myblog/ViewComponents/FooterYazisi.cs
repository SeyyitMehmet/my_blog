using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
    public class FooterYazisi:ViewComponent
    {
        FooterManager fm = new FooterManager(new EfFooterRepo());
        public IViewComponentResult Invoke()
        {

            var values = fm.GetList();
            //ViewBag.Data = values;
            return View(values);
        }
    }
}
