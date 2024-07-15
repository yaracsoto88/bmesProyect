namespace bmesProyect.Messages.DataTransferObjects.Product
{
    public class BrandDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public int BrandStatus { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } 
    }
}