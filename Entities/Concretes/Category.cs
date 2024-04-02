using Core.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:Entity<Guid>
    {
        public string Name { get; set; }


        public ICollection<Product> Products { get; set;}
        public ICollection <SubCategory> SubCategories { get; set; }

       

    }
}
