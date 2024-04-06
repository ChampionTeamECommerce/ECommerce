using System;
namespace Business.DTOs.UserAddresses.Request
{
	public class UpdateUserAddressesRequest
	{
		public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AddressId { get; set; }
    }
}

