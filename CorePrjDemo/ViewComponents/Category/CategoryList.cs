using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager manageCategory = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var categories = manageCategory.GetAllEntityItems();
            return View(categories);
        } 
    }
}
