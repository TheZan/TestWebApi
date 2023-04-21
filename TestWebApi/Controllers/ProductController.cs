using Microsoft.AspNetCore.Mvc;
using TestWebApi.Infrastructure;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = TestData.Products;

        /// <summary>
        /// ���������� ��� �������� �� ���������.
        /// </summary>
        /// <returns>��������� ���������.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _products;
        }

        /// <summary>
        /// ���������� ������� � ��������� ��������������� �� ���������.
        /// </summary>
        /// <param name="id">������������� ��������.</param>
        /// <returns>������� � ��������� ���������������.</returns>
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        /// <summary>
        /// ������� ����� ������� � ���������.
        /// </summary>
        /// <param name="product">������� ��� ��������.</param>
        /// <returns>��������� ��������.</returns>
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        /// <summary>
        /// ��������� ������������ ������� � ���������.
        /// </summary>
        /// <param name="id">������������� ��������.</param>
        /// <param name="product">����� ������ ��� ��������.</param>
        /// <returns>��������� ��������.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            return NoContent();
        }

        /// <summary>
        /// ������� ������� � ��������� ��������������� �� ���������.
        /// </summary>
        /// <param name="id">������������� ��������.</param>
        /// <returns>��������� ��������.</returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            _products.Remove(existingProduct);
            return NoContent();
        }
    }
}