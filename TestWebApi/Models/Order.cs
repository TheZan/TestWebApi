namespace TestWebApi.Models
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя заказчика.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Список продуктов, включенных в заказ.
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Общая стоимость заказа, вычисляемая как сумма цен всех продуктов в заказе.
        /// </summary>
        public decimal TotalPrice => Products.Sum(p => p.Price);
    }
}
