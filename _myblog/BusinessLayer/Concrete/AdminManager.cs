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
	public class AdminManager : IAdminService
	{
		IAdminDal _adminDall;

		public AdminManager(IAdminDal adminDall)
		{
			_adminDall = adminDall;
		}

		public void AddT(deneme1 t)
		{
			_adminDall.Insert(t);
		}

		public void DeleteT(deneme1 t)
		{
			_adminDall.Delete(t);
		}

		public deneme1 GetById(int id)
		{
			return _adminDall.GetById(id);		
		}

		public List<deneme1> GetList()
		{
			return _adminDall.GetListAll();
		}

		public void UpdateT(deneme1 t)
		{
			_adminDall.update(t);
		}
	}
}