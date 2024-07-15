using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bmesProyect.Messages.DataTransferObjects.Product;

namespace bmesProyect.Messages.Request.Brand
{
    public class CreateBrandRequest
    {
        public BrandDTO Brand { get; set; }
    }
}