using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Product.Response
{
    public class CreatedProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StockAmount { get; set; }
        public double ProductPrice { get; set; }

        public Guid? CategoryId { get; set; }

        public Guid? GenderId { get; set; }
        public Guid? SizeId { get; set; }
        public Guid? ColorId { get; set; }
    }
}

