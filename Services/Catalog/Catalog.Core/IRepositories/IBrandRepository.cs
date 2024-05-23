using Catalog.Core.Entities;

namespace Catalog.Core.IRepositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<ProductBrand>> GetAllBrands();
    }
}
