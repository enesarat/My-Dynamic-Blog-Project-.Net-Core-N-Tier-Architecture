using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CorePrjDemo.Models.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager manageAuthor = new AuthorManager(new EfAuthorRepository());
        CountryManager manageCountry = new CountryManager(new EfCountryRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var vm = new AuthorCountry();
            vm.Countries = manageCountry.GetAllEntityItems();
            
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(AuthorCountry newAuthor, string AuthorPasswordCheck)
        {
            AuthorValidation validationRules = new AuthorValidation();
            ValidationResult validationResult = validationRules.Validate(newAuthor.Author);
            if (validationResult.IsValid)
            {
                if (newAuthor.Author.AuthorPassword == AuthorPasswordCheck)
                {
                    newAuthor.Author.AuthorStatus = true;
                    newAuthor.Author.AuthorInfo = "Default Author Info";
                   
                    manageAuthor.InsertEntity(newAuthor.Author);
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    return RedirectToAction("Index", "Register");
                }
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError("Author." + item.PropertyName, item.ErrorMessage);
                }
                
                var vm = new AuthorCountry();
                vm.Countries = manageCountry.GetAllEntityItems();

                return View(vm);
            }

        }
    }
}
