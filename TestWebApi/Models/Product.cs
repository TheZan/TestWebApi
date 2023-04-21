namespace TestWebApi.Models
{
    public class Product
    {
        /// <summary>
        /// Уникальный идентификатор продукта.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание продукта.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Количество продукта в наличии.
        /// </summary>
        public int Quantity { get; set; }
    }
}
