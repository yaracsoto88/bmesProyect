using bmesProyect.Messages.DataTransferObjects.Product;
using bmesProyect.Messages.Response.Product;

namespace bmesProyect.Messages.Response.Category
{
    public class FetchCategoryResponse: ResponseBase
    {
        public int CategorysPerPage  { get; set;}
        public bool HasPreviousPages {get; set;}
        public bool HasNextPages {get; set;}
        public int CurrentPage {get; set;}
        public int[] Pages {get; set;}
        public IEnumerable<CategoryDTO> Category {get; set;}
    }
}