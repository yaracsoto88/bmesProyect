using bmesProyect.Messages.DataTransferObjects.Product;
using bmesProyect.Messages.Response.Product;

namespace bmesProyect.Messages.Response.Category
{
    public class CreateCategoryResponse: ResponseBase
    {
        public CategoryDTO Category { get; set; }
    }
}