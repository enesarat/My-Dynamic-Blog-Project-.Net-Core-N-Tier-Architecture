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
    public class CountryManager : ICountryService
    {
        ICountryDAL countryAccess;

        public CountryManager(ICountryDAL accessLevelType)
        {
            countryAccess = accessLevelType;
        }

        public void DeleteEntity(Country entity)
        {
            countryAccess.Delete(entity);
        }

        public List<Country> GetAllEntityItems()
        {
            return countryAccess.GetAllItems();
        }

        public Country GetEntityById(int id)
        {
            return countryAccess.GetById(id);
        }

        public List<Country> GetListAllByFilter(Expression<Func<Country, bool>> filter)
        {
            return countryAccess.GetAllItemsByFilter(filter);
        }

        public void InsertEntity(Country entity)
        {
            countryAccess.Insert(entity);
        }

        public void UpdateEntity(Country entity)
        {
            countryAccess.Update(entity);
        }
    }
}
