using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bmesProyect.Models.Product;

namespace bmesProyect.Repositories
{
    public interface IBrandRepository
    {
        Brand FindBrandById(long id);
        IEnumerable<Brand> GetAllBrands();
        void SaveBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        
    }
}