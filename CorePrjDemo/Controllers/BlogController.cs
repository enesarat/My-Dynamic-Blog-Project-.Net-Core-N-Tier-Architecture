﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager manageBlog = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var listOfBlogs = manageBlog.GetAllEntityItems();
            return View(listOfBlogs);
        }
    }
}
