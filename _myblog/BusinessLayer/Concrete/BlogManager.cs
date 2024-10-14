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
	public class BlogManager : IBlogService
	{
		IBlogDal _blogdall;

		public BlogManager(IBlogDal blogdall)
		{
			_blogdall = blogdall;
		}

		public void AddT(Blog t)
		{
			_blogdall.Insert(t);
		}

		public void DeleteT(Blog t)
		{
			_blogdall.Delete(t);
		}

		public Blog GetById(int id)
		{
			return _blogdall.GetById(id);
		}

		public List<Blog> GetList()
		{
			return _blogdall.GetListAll();
		}
		public List<Blog>GetBlogByID(int id)
		{
			return _blogdall.GetListAll(x=>x.BlogID== id);
		}
		public void UpdateT(Blog t)
		{
			_blogdall.update(t);
		}
	}
}
