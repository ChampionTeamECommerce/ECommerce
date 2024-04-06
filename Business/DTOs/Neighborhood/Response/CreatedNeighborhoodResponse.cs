using System;
namespace Business.DTOs.Neighborhood.Response
{
	public class CreatedNeighborhoodResponse
	{
        public string Name { get; set; }
        public Guid DistrictId { get; set; }
        public Guid Id { get; set; }
    }
}

