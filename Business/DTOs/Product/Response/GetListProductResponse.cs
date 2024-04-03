namespace Business.DTOs.Product.Response
{
    public class GetListProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StockAmount { get; set; }
        public double ProductPrice { get; set; }

        public string CategoryName { get; set; }

        public string GenderName { get; set; }
        public string SizeName { get; set; }
        public string ColorName { get; set; }
    }
}

