using Dapper.Application.Interfaces;
using Dapper.Core.Entities;

namespace AZ204DemoApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            IReadOnlyList<Product> Products = await _unitOfWork.Products.GetAllAsync();
            return Products.ToList();
        }
    }
}
