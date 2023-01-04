using Artisanaux.Services.ProductAPI.Models.Dto;
using Artisanaux.Services.ProductAPI.Services.IServices;

namespace Artisanaux.Services.ProductAPI.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        

        public ProductService(IHttpClientFactory httpClientFactory):base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto, string token)
        {
            //this.SendAsync<T>(new ApiRequest()
            //{
            //ApiType = SD.ApiType.POST,
            //Data = productDto,
            //URL = SD.ProductAPIBase + "/api/products",
            //AccessToken = token
            //}
            //);
        }

        public Task<T> DeleteProductsAsync<T>(int id, string token)
        {
            //this.SendAsync<T>(new ApiRequest()
            //{
            //ApiType = SD.ApiType.DELETE,
            //URL = SD.ProductAPIBase + "/api/products"+id,
            //AccessToken = token
            //}
            //);
        }

        public Task<T> GetAllProductsAsync<T>(string token)
        {
            //this.SendAsync<T>(new ApiRequest()
            //{
                //ApiType = SD.ApiType.GET,
                //URL = SD.ProductAPIBase + "/api/products",
                //AccessToken = token
            //}
            //);
        }

        public Task<T> GetProductByIdAsync<T>(int id, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto, string token)
        {
            //this.SendAsync<T>(new ApiRequest()
            //{
            //ApiType = SD.ApiType.PUT,
            //Data = productDto,
            //URL = SD.ProductAPIBase + "/api/products",
            //AccessToken = token
            //}
            //);
        }
    }
}
