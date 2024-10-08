﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class AdminManager : IAdminService
	{
		IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public void AdminAdd(Admin admin)
		{
			_adminDal.Insert(admin);
		}

		public void AdminDelete(Admin admin)
		{
			_adminDal.Delete(admin);
		}

		public void AdminUpdate(Admin admin)
		{
			_adminDal.Update(admin);
		}

		public Admin GetByID(int id)
		{
			return _adminDal.Get(x => x.AdminId == id);
		}

		public Admin GetByUserName(string username)
		{
			return _adminDal.Get(x => x.AdminUserName == username);
		}

		public List<Admin> GetList()
		{
			return _adminDal.List();
		}

		public Admin GetUsernamePassword(string username, string password)
		{
			return _adminDal.Get(x => x.AdminUserName == username && x.AdminPassword == password);
		}
	}
}