namespace bmesProyect.Messages.Request.Product
{
    public class FetchProductRequest
    {
        public int PageNumbers { get; set; }
        public int ProductSPerPage { get; set; }
        public string CategorySlug { get; set; }
        public string BrandSlug { get; set; }
    }
}