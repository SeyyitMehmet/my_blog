﻿using DataAcsessLayer.Abstract;
using DataAcsessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Repositories
{


	public class genericReopsitory<T> : IGenericDal<T> where T : class
	{
		Context c = new Context();
		public void Delete(T t)
		{
			c.Remove(t);
			c.SaveChanges();
		}

		public T GetById(int id)
		{
			return c.Set<T>().Find(id);
		}

		public List<T> GetListAll(
			)
		{
			return c.Set<T>().ToList();
		}

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			return c.Set<T>().Where(filter).ToList();
		}



		public void Insert(T t)
		{
			c.Add(t);
			c.SaveChanges();
		}

		public List<T> List(Expression<Func<T, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void update(T t)
		{
			c.Update(t);
			c.SaveChanges();
		}

	}
}
