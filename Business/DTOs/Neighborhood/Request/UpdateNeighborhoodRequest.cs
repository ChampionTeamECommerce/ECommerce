using System;
namespace Business.DTOs.Neighborhood.Request
{
	public class UpdateNeighborhoodRequest
	{
        public string Name { get; set; }
        public Guid DistrictId { get; set; }
        public Guid Id { get; set; }

    }
}

