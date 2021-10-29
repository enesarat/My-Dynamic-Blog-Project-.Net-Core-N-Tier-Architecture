using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager manageAbout = new AboutManager(new EfAboutRepository()); 
        public IActionResult Index()
        {
            var aboutList = manageAbout.GetAllEntityItems();
            return View(aboutList);
        }

        public PartialViewResult SocialMediaAccounts()
        {
            return PartialView();
        }
    }
}
