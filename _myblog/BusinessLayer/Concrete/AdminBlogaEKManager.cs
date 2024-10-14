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
    public class AdminBlogaEKManager : IAdminBlogaEkService
    {
        IAdminBlogaEKDal _adminblogaEkdall;

        public AdminBlogaEKManager(IAdminBlogaEKDal adminblogaEkdall)
        {
            _adminblogaEkdall = adminblogaEkdall;
        }

        public void AddT(AdminBlogaEK t)
        {
           _adminblogaEkdall.Insert(t);
        }

        public void DeleteT(AdminBlogaEK t)
        {
            _adminblogaEkdall.Delete(t);
        }

        public AdminBlogaEK GetById(int id)
        {
            return _adminblogaEkdall.GetById(id);
        }

        public List<AdminBlogaEK> GetList()
        {
            return _adminblogaEkdall.GetListAll();
        }
        public List<AdminBlogaEK> GetBlogEKAdminByID(int id)
        {
            return _adminblogaEkdall.GetListAll(x => x.BlogID == id);
        }

        public void UpdateT(AdminBlogaEK t)
        {
            _adminblogaEkdall.update(t);

        }
    }
}
