using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager manageComment = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var listOfComments = manageComment.GetListAllByFilter(x => x.BlogID == id);
            ViewBag.commentCount = listOfComments.Count();
            return View(listOfComments);
        }
    }
}
