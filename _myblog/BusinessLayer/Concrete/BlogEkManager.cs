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
	public class BlogEkManager : IBlogEkService
	{
		IBlogEkDal _blogEkdall;

		public BlogEkManager(IBlogEkDal blogEkdall)
		{
			_blogEkdall = blogEkdall;
		}

		public void AddT(BlogEk t)
		{
			_blogEkdall.Insert(t);	
		}

		public void DeleteT(BlogEk t)
		{
			_blogEkdall.Delete(t);
		}

		public BlogEk GetById(int id)
		{
			return _blogEkdall.GetById(id);
		}

		public List<BlogEk> GetList()
		{
			return _blogEkdall.GetListAll();
		}
		public List<BlogEk> GetBlogEkByID(int id)
		{
			return _blogEkdall.GetListAll(x => x.BlogID == id);
		}
        public List<BlogEk> GetBlogEkAdminByID(int id)
        {
            return _blogEkdall.GetListAll(x => x.KullaniciID == id);
        }
        public void UpdateT(BlogEk t)
		{
			_blogEkdall.update(t);
		}
	}
}
