using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.ViewComponents.Blog
{
    public class RecentPostsOfAuthor : ViewComponent
    {
        BlogManager manageBlog = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var postsOfAuthor = manageBlog.GetBlogListByAuthor(id);
            return View(postsOfAuthor);
        }
    }
}
