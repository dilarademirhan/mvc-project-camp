using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category category)
        {
            if(category.CategoryName == "" || category.CategoryName.Length <= 3
                || category.CategoryDescription == "" || category.CategoryName.Length >= 51)
            {

            }
            else
            {
                repo.Insert(category);
            }
        }
    }
    
}
