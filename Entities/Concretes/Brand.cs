using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Brand : Entity<Guid>
    {
        public string Name { get; set; }

        //public ICollection<Product> Products { get; set; }

    }
}
