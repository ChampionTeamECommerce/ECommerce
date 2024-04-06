using System;
namespace Business.DTOs.UserAddresses.Request
{
	public class CreateUserAddressesRequest
	{
        public string Name { get; set; }
        public Guid AddressId { get; set; }
    }
}

