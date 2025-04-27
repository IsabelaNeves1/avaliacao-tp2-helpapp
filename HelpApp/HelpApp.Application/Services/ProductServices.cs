using HelpApp.Application.Interfaces;
using HelpApp.Domain.Interfaces;
using HelpApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productRepository.GetProducts();
        }
        public async Task<Product> GetProductByIdAsync(int? id)
        {
            return await _productRepository.GetById(id);
        }
        public async Task CreateProductAsync(Product product)
        {
            await _productRepository.Create(product);
        }
        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.Update(product);
        }
        public async Task RemoveProductAsync(int id)
        {
            var productToRemove = await _productRepository.GetById(id);
            if (productToRemove != null)
            {
                await _productRepository.Remove(productToRemove);
            }
        }
    }
}
