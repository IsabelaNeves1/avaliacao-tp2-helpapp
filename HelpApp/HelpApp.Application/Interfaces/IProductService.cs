using HelpApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpApp.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int? id);
        Task CreateProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task RemoveProductAsync(int id);
    }
}
