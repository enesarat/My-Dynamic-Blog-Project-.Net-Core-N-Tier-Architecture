using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author : IEntity
    {
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorInfo { get; set; }
        public string AuthortImage { get; set; }
        public string AuthorMail { get; set; }
        public string AuthorPassword { get; set; }
        public bool AuthorStatus { get; set; }
    }
}
