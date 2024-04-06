using System;
namespace Business.DTOs.Neighborhood.Request
{
	public class CreateNeighborhoodRequest
	{
        public string Name { get; set; }
        public Guid DistrictId { get; set; }

    }
}

