﻿using System;
namespace Business.DTOs.UserAddresses.Response
{
	public class CreatedUserAddressesResponse
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AddressId { get; set; }
    }
}

