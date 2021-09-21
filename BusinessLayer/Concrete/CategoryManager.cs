using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL categoryAccess;
        public CategoryManager(ICategoryDAL accessLevelType)
        {
            categoryAccess = accessLevelType;
        }
        public void DeleteEntity(Category entity)
        {
            categoryAccess.Delete(entity);
        }

        public List<Category> GetAllEntityItems()
        {
            return categoryAccess.GetAllItems();
        }

        public Category GetEntityById(int id)
        {
            return categoryAccess.GetById(id);
        }

        public void InsertEntity(Category entity)
        {
            categoryAccess.Insert(entity);
        }

        public void UpdateEntity(Category entity)
        {
            categoryAccess.Update(entity);
        }
    }
}
