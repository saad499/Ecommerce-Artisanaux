using Artisanaux.Services.ProductAPI.Models.Dto;
using Artisanaux.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artisanaux.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDto _response;
        public IProductRepository _productRepository;

        public ProductAPIController(ResponseDto response, IProductRepository productRepository)
        {
            _response = response;
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            {
                IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
                _response.Result = productDtos;
                return _response;
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object>GetById(int id)
        {
            ProductDto product = await _productRepository.GetProductById(id);
            _response.Result = product;
            return _response;
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        [Route("{id}")]
        public async Task<object> DeleteById(int id)
        {
            bool isSuccess = await _productRepository.DeleteProduct(id);
            _response.Result = isSuccess;
            return _response;
        }
    }
}
