using GeekShopping.ProductAPI.Data.DTO;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> FIndByAll()
        {
            var products = await _productRepository.FindAll();
            if (products == null) return NotFound();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> FIndById(long id)
        {
            var product = await _productRepository.FindById(id);
            if(product.Id <= 0) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Create(ProductDTO productDto)
        {
            if(productDto == null) return NotFound();            
            var product = await _productRepository.Create(productDto);            
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductDTO>> Update(ProductDTO productDto)
        {
            if (productDto == null) return NotFound();
            var product = await _productRepository.Update(productDto);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var status = await _productRepository.Delete(id);
            if (status)
                return Ok(status);
            return BadRequest();
        }
    }
}
