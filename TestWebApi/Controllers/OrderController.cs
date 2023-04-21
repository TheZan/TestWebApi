using Microsoft.AspNetCore.Mvc;
using TestWebApi.Infrastructure;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> _orders = TestData.Orders;

        /// <summary>
        /// Возвращает все заказы из хранилища.
        /// </summary>
        /// <returns>Коллекцию заказов.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return _orders;
        }

        /// <summary>
        /// Получает заказ по указанному идентификатору
        /// </summary>
        /// <param name="id">Идентификатор заказа</param>
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        /// <summary>
        /// Создает новый заказ
        /// </summary>
        /// <param name="order">Данные заказа</param>
        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }

        /// <summary>
        /// Обновляет данные заказа по указанному идентификатору
        /// </summary>
        /// <param name="id">Идентификатор заказа</param>
        /// <param name="order">Новые данные заказа</param>
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] Order order)
        {
            var existingOrder = _orders.FirstOrDefault(o => o.Id == id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.CustomerName = order.CustomerName;
            existingOrder.Products = order.Products;
            return NoContent();
        }

        /// <summary>
        /// Удаляет заказ по указанному идентификатору
        /// </summary>
        /// <param name="id">Идентификатор заказа</param>
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var existingOrder = _orders.FirstOrDefault(o => o.Id == id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            _orders.Remove(existingOrder);
            return NoContent();
        }
    }
}
