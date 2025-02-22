﻿using AutoMapper;
using GeekShopping.ProductAPI.Data.DTO;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<ProductDTO> FindById(long id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> Create(ProductDTO productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(product);
        }
        public async Task<ProductDTO> Update(ProductDTO productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
                if (product.Id <= 0)
                {
                    return false;
                }
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
