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

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
		{
            return _categoryDal.Get(category => category.CategoryId ==  id);
		}

		public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        // public void CategoryAddBL(Category category)
        // {
        //     if(category.CategoryName == "" || category.CategoryStatus == false || 
        //         category.CategoryName.Length <= 2)
        //     {

        //     } 
        //     else
        //     {
        //         _categoryDal.Insert(category);
        //     }
        // }
        
    }
    
}
