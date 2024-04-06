using System;
namespace Business.DTOs.UserAddresses.Response
{
	public class DeletedUserAddressesResponse
	{
        public string Name { get; set; }
        public Guid AddressId { get; set; }
        public Guid Id { get; set; }
    }
}

