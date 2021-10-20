using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
       
        /*public List<Blog> GetAllItemsByFilter(Expression<Func<Blog, bool>> filter)
        {
            using (Context dbContext = new Context())
            {
                if (filter == null)
                {
                    var entityList = dbContext.Blogs.ToList();
                    return entityList;
                }
                else
                {
                    var entityList = dbContext.Blogs.Where(filter).ToList();
                    return entityList;
                }
            }
        }*/
        public List<Blog> GetListWithCategories()
        {
            using (var c = new Context())
            {
                var BlogListWithCategory = c.Blogs.Include(x=>x.Category).ToList();
                return BlogListWithCategory;
            }
            
        }
    }
}
