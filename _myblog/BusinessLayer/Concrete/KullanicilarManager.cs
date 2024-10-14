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
    public class KullanicilarManager : IKullanicilarService
    {
        IKullanicilarDal _kullaicilardall;

        public KullanicilarManager(IKullanicilarDal kullaicilardall)
        {
            _kullaicilardall = kullaicilardall;
        }

        public void AddT(Kullanicilar t)
        {
            _kullaicilardall.Insert(t); 
        }

        public void DeleteT(Kullanicilar t)
        {
            _kullaicilardall.Delete(t);
        }

        public Kullanicilar GetById(int id)
        {
            return _kullaicilardall.GetById(id);
        }

        public List<Kullanicilar> GetList()
        {
            return _kullaicilardall.GetListAll();
        }
        public List<Kullanicilar> GetBlogByID(int id)
        {
            return _kullaicilardall.GetListAll(x => x.KullaniciID == id);
        }

        public void UpdateT(Kullanicilar t)
        {
            _kullaicilardall.update(t);
        }
    }
}
