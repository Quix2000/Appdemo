using Dapper.Core.Entities;

namespace AZ204DemoApp.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
    }
}
