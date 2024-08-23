using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAddBL(Category category)
        {
            if(category.CategoryName == "" || category.CategoryStatus == false || 
                category.CategoryName.Length <= 2)
            {

            } else
            {
                _categoryDal.Insert(category);
            }
        }
        
    }
    
}
