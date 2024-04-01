using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ContactSubject:Entity<Guid>
    {
        public string Name { get; set; }     


        public ICollection <ContactUs> ContactUs { get; set; }
    }
}
