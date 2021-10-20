﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Country : IEntity
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
