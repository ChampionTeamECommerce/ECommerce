using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ContactUs:Entity<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email {  get; set; }
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }
        public string? MembershipCard { get; set; }


        public Guid ContactSubjectId { get; set; }

        public virtual ContactSubject? ContactSubject { get; set; }

    }
}
