using bmesProyect.Messages.DataTransferObjects.Product;
using bmesProyect.Messages.Response.Product;

namespace bmesProyect.Messages.Response.Brand
{
    public class GetBrandResponse:ResponseBase
    {
        public BrandDTO Brand {get; set;}
    }
}