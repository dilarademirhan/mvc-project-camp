using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IAdminService
	{
		List<Admin> GetList();
		Admin GetUsernamePassword(string username, string password);
		void AdminAdd(Admin admin);
		Admin GetByID(int id);
		Admin GetByUserName(string username);
		void AdminDelete(Admin admin);
		void AdminUpdate(Admin admin);
	}
}