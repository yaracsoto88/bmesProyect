using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bmesProyect.Models.Product
{
    public class Brand
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public BrandStatus BrandStatus { get; set; }
    }
}
