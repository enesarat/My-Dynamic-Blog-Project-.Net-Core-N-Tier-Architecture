using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CorePrjDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Author theAuthor)
        {
            Context db_c = new Context();
            var authorCheck = db_c.Authors.FirstOrDefault(x => x.AuthorMail == theAuthor.AuthorMail && x.AuthorPassword == theAuthor.AuthorPassword);
            if (authorCheck!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,theAuthor.AuthorMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Author");
            }
            else
            {
                return View();
            }
            
        }
    }
}
