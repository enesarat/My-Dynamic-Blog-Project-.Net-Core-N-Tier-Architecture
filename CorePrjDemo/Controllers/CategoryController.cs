using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager manageCategory = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var categoryList = manageCategory.GetAllEntityItems();
            return View(categoryList);
        }
    }
}
