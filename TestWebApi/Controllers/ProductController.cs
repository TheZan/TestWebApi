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
        /// Возвращает все продукты из хранилища.
        /// </summary>
        /// <returns>Коллекцию продуктов.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _products;
        }

        /// <summary>
        /// Возвращает продукт с указанным идентификатором из хранилища.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором.</returns>
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
        /// Создает новый продукт в хранилище.
        /// </summary>
        /// <param name="product">Продукт для создания.</param>
        /// <returns>Результат действия.</returns>
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        /// <summary>
        /// Обновляет существующий продукт в хранилище.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <param name="product">Новые данные для продукта.</param>
        /// <returns>Результат действия.</returns>
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
        /// Удаляет продукт с указанным идентификатором из хранилища.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Результат действия.</returns>
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