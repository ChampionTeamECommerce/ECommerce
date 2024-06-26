﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Country : Entity<Guid>
    {
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<City> Cities { get; set;}    

    }
}
