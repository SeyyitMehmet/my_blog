using BusinessLayer.Abstract;
using DataAcsessLayer.Abstract;
using Entitylayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NavbarManager: INavbarService
    {
        INavbarDal _navbardall;

        public NavbarManager(INavbarDal navbardall)
        {
            _navbardall = navbardall;
        }

        public void AddT(NavbarYonetimi t)
        {
            _navbardall.Insert(t);
        }

        public void DeleteT(NavbarYonetimi t)
        {
            _navbardall.Delete(t);
        }

        public NavbarYonetimi GetById(int id)
        {
            return _navbardall.GetById(id);
        }

        public List<NavbarYonetimi> GetList()
        {
            return _navbardall.GetListAll();
        }
        public List<NavbarYonetimi> GetNavbarByID(int id)
        {
            return _navbardall.GetListAll(x => x.NavbarID == id);
        }

        public void UpdateT(NavbarYonetimi t)
        {
            _navbardall.update(t);
        }
    }
}
