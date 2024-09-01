using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal _contactDal {  get; set; }

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void ContactAdd(Contact contact)
		{
			_contactDal.Insert(contact);
		}

		public void ContactDelete(Contact contact)
		{
			_contactDal.Delete(contact);
		}

		public void ContactUpdate(Contact contact)
		{
			_contactDal.Update(contact);
		}

		public Contact GetByID(int id)
		{
			return _contactDal.Get(x => x.ContactId == id);
		}

		public List<Contact> GetList()
		{
			return _contactDal.List();
		}
	}
}
