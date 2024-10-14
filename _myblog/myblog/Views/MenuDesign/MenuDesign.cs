using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myblog.Views.MenuDesign
{
    public class MenuDesign : ViewComponent
    {
        MenuManager mm = new MenuManager(new EfManuRepo());
        public IViewComponentResult Invoke()
        {
            var values = mm.GetList();
            return View(values);
        }
    }
}
