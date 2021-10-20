using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDAL : IGenericEntityDAL<Blog>
    {
        List<Blog> GetListWithCategories();
        //List<Blog> GetAllItemsByFilter(Expression<Func<Blog, bool>> filter);
    }
}
