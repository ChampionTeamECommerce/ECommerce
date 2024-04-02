using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User:Entity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }  
        public DateTime? BirthDate { get; set; }


        public string? IdentityNumber { get; set; }


        
        public Guid UserAddressesId { get; set; }
        public Guid GenderId { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Gender> Genders { get; set; }
        public ICollection<UserAddresses> UserAddresses { get; set; }

    }
}
