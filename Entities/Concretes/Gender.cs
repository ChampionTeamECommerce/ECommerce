using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Gender:Entity<Guid>
    {
        public string Name { get; set; }

        public ICollection<Clothes> Clothes { get; set; } // iki cinsinde kullandığı kıyafetler unisex olarak tutulacak
    }
}
