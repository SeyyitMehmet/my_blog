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
	public class MenuManager : IMenuService
	{
		IMenuDal _menudal;

		public MenuManager(IMenuDal menudal)
		{
			_menudal = menudal;
		}

		public void AddT(Menu t)
		{
			_menudal.Insert(t);	
		}

		public void DeleteT(Menu t)
		{
			_menudal.Delete(t);	
		}

		public Menu GetById(int id)
		{
			return _menudal.GetById(id);
		}

		public List<Menu> GetList()
		{
			return _menudal.GetListAll();
		}
        public List<Menu> GetMenuByID(int id)
        {
            return _menudal.GetListAll(x => x.MenuID == id);
        }

        public void UpdateT(Menu t)
		{
			_menudal.update(t);	
		}
	}
}
