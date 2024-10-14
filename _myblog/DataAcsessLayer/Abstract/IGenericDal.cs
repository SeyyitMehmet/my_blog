using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Abstract
{
	public interface IGenericDal<T> where T : class//entitty temsil ediyor  T where ise sınıfın tamamını kulallanması sağlıyor
	{
	
			void Insert(T t); // tablo vs ekleme işlemleri
			void Delete(T t);
			void update(T t);
			List<T> GetListAll();
			T GetById(int id);
			List<T> GetListAll(Expression<Func<T, bool>> filter);
		
	}
}
