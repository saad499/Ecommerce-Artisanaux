using Artisanaux.Services.ProductAPI.Models.Dto;

namespace Artisanaux.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        object Products { get; set; }

        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateProduct(ProductDto product);
        Task<bool> DeleteProduct(int productId);
    }
}
