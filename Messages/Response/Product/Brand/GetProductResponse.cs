using bmesProyect.Messages.DataTransferObjects.Product;
using bmesProyect.Messages.Response.Product;

namespace bmesProyect.Messages.Response.Product
{
    public class GetProductResponse:ResponseBase
    {
        public ProductDTO Product {get; set;}
    }
}