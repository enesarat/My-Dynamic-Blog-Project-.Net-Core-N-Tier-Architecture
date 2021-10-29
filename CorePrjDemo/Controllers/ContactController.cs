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
    public class ContactController : Controller
    {
        ContactManager manageContact = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact newContact)
        {
            newContact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            newContact.ContactStatus = true;
            manageContact.InsertEntity(newContact);
            return RedirectToAction("Index","Blog");
        }
    }
}
