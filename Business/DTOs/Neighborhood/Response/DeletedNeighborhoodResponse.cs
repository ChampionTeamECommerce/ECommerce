using System;
namespace Business.DTOs.Neighborhood.Response
{
	public class DeletedNeighborhoodResponse
    {
        public string Name { get; set; }
        public Guid DistrictId { get; set; }
        public Guid Id { get; set; }
    }
}

