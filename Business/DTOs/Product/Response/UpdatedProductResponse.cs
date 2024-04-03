namespace Business.DTOs.Product.Response
{
    public class UpdatedProductResponse
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

