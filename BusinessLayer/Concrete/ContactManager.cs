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
    public class ContactManager : IContactService
    {
        IContactDAL contactAccess;

        public ContactManager(IContactDAL accessLevelType)
        {
            contactAccess = accessLevelType;
        }

        public void DeleteEntity(Contact entity)
        {
            contactAccess.Delete(entity);
        }

        public List<Contact> GetAllEntityItems()
        {
            return contactAccess.GetAllItems();
        }

        public Contact GetEntityById(int id)
        {
            return contactAccess.GetById(id);
        }

        public List<Contact> GetListAllByFilter(Expression<Func<Contact, bool>> filter)
        {
            return contactAccess.GetAllItemsByFilter(filter);
        }

        public void InsertEntity(Contact entity)
        {
            contactAccess.Insert(entity);
        }

        public void UpdateEntity(Contact entity)
        {
            contactAccess.Update(entity);
        }
    }
}
