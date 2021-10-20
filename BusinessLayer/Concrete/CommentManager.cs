using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL commentAccess;

        public CommentManager(ICommentDAL accessLevelType)
        {
            commentAccess = accessLevelType;
        }
        public void DeleteEntity(Comment entity)
        {
            commentAccess.Delete(entity);
        }

        public List<Comment> GetAllEntityItems()
        {
            return commentAccess.GetAllItems();
        }

        public Comment GetEntityById(int id)
        {
            return commentAccess.GetById(id);
        }

        public List<Comment> GetListAllByFilter(Expression<Func<Comment, bool>> filter)
        {
            return commentAccess.GetAllItemsByFilter(filter);
        }

        public void InsertEntity(Comment entity)
        {
            commentAccess.Insert(entity);
        }

        public void UpdateEntity(Comment entity)
        {
            commentAccess.Update(entity);
        }
    }
}
