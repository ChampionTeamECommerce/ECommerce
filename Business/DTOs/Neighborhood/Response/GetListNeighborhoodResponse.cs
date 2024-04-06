using System;
namespace Business.DTOs.Neighborhood.Response
{
	public class GetListNeighborhoodResponse
	{
        public string Name { get; set; }
        public Guid DistrictId { get; set; }
        public Guid Id { get; set; }

    }
}

