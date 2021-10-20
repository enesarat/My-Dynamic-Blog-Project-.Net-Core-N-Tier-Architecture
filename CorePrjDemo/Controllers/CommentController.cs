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
    public class CommentController : Controller
    {
        CommentManager manageComment = new CommentManager(new EfCommentRepository());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult AddComment(string name, string email, string subject, string message, string blog)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(subject) && !string.IsNullOrEmpty(blog))
            {
                manageComment.InsertEntity(new Comment()
                {
                    CommentUserName = name,
                    CommentTitle = subject,
                    CommentContent = message,
                    CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                    CommentStatus = true,
                    BlogID = int.Parse(blog)
                });

                return Json(1);
            }
            return Json(0);
        }

        //public PartialViewResult CommentListOfBlog(int id) // SİLİNECEK
        //{
        //    var commentsOfBlog = manageComment.GetListAllByFilter(x=>x.BlogID == id);
        //    return PartialView(commentsOfBlog);
        //}
    }
}
