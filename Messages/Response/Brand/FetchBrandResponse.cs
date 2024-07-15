using bmesProyect.Messages.DataTransferObjects.Product;
using bmesProyect.Messages.Response.Product;

namespace bmesProyect.Messages.Response.Brand
{
    public class FetchBrandResponse: ResponseBase
    {
        public int BrandsPerPage  { get; set;}
        public bool HasPreviousPages {get; set;}
        public bool HasNextPages {get; set;}
        public int CurrentPage {get; set;}
        public int[] Pages {get; set;}
        public IEnumerable<BrandDTO> Brands {get; set;}
    }
}