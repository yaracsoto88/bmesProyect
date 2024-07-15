using bmesProyect.Messages.DataTransferObjects.Product;
using bmesProyect.Messages.Response.Product;

namespace bmesProyect.Messages.Response.Product
{
    public class FetchProductResponse: ResponseBase
    {
        public int ProductsPerPage  { get; set;}
        public bool HasPreviousPages {get; set;}
        public bool HasNextPages {get; set;}
        public int CurrentPage {get; set;}
        public int[] Pages {get; set;}
        public IEnumerable<ProductDTO> Product {get; set;}
    }
}