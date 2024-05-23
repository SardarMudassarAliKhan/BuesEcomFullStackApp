using Catalog.Core.Entities;

namespace Catalog.Core.IRepositories
{
    public interface ITypesRepository
    {
        Task<IEnumerable<ProductType>> GetAllTypes();
    }
}
