using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePrjDemo.Models.ViewModels
{
    public class AuthorCountry
    {
        public Author Author { get; set; }
        public int Country  { get; set; }
        public List<Country> Countries { get; set; }
    }
}
