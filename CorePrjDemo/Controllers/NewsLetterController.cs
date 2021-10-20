using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager manageNewsLetter = new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeByMail()
        {
            return PartialView();  
        }

        [HttpPost]
        public JsonResult SubscribeByMail(string mail)
        {
            if (!string.IsNullOrEmpty(mail))
            {
                manageNewsLetter.InsertEntity(new NewsLetter()
                {
                    Mail = mail
                });

                return Json(1);
            }
            return Json(0);
        }

    }
}
