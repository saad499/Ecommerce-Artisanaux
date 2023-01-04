using Artisanaux.Services.ProductAPI.DbContexts;
using Artisanaux.Services.ProductAPI.Models;
using Artisanaux.Services.ProductAPI.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Artisanaux.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(IProductRepository db, IMapper mapper)
        {
            _db = (ApplicationDbContext)db;
            _mapper = mapper;
        }

        public object Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<ProductDto> CreateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            Productcs productcs = await _db.Products.FirstOrDefaultAsync(p => p.IdProduct == productId);
            if (productcs == null)
            {
                return false;
            }
            _db.Products.Remove(productcs);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Productcs products = await _db.Products.Where(p => p.IdProduct == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(products);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Productcs> productcs = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productcs);
        }

        
    }
}
