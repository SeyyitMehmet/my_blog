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
    public class FooterManager : IFooterService
    {
        IFooterDal _footerdall;

        public FooterManager(IFooterDal footerdall)
        {
            _footerdall = footerdall;
        }

        public void AddT(Footer t)
        {
           _footerdall.Insert(t);
        }

        public void DeleteT(Footer t)
        {
            _footerdall.Delete(t);
        }

        public Footer GetById(int id)
        {
            return _footerdall.GetById(id); 
        }

        public List<Footer> GetList()
        {
            return _footerdall.GetListAll();
        }
        public List<Footer> GetFooterByID(int id)
        {
            return _footerdall.GetListAll(x => x.FooterID == id);
        }

        public void UpdateT(Footer t)
        {
            _footerdall.update(t);
        }
    }
}
