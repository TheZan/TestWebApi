using TestWebApi.Models;

namespace TestWebApi.Infrastructure;

public static class TestData
{
    public static List<Product> Products { get; set; }
    public static List<Order> Orders { get; set; }

    static TestData()
    {
        Products = new List<Product>
        {
            new()
            {
                Id = 1, Name = "iPhone 13 Pro Max",
                Description = "Apple smartphone with 6.7-inch display and 1TB storage", Price = 1599.99M, Quantity = 10
            },
            new()
            {
                Id = 2, Name = "Samsung Galaxy S21 Ultra",
                Description = "Samsung smartphone with 6.8-inch display and 512GB storage", Price = 1399.99M,
                Quantity = 5
            },
            new()
            {
                Id = 3, Name = "Sony WH-1000XM4",
                Description = "Wireless noise-canceling headphones with Alexa voice control", Price = 349.99M,
                Quantity = 20
            },
            new()
            {
                Id = 4, Name = "AmazonBasics AAA 1.5 Volt Performance Alkaline Batteries",
                Description = "Pack of 36 AAA alkaline batteries", Price = 11.99M, Quantity = 100
            },
            new()
            {
                Id = 5, Name = "Corsair K95 RGB Platinum XT Mechanical Gaming Keyboard",
                Description = "Cherry MX Speed RGB Silver mechanical switches and per-key RGB backlighting",
                Price = 199.99M, Quantity = 10
            },
            new()
            {
                Id = 6, Name = "Телефон Samsung Galaxy S21 Ultra 5G",
                Description = "6,8 дюймовый экран, 12 ГБ ОЗУ, 256 ГБ памяти, камера 108 МП", Price = 84990M,
                Quantity = 100
            },
            new()
            {
                Id = 7, Name = "Ноутбук Apple MacBook Pro 16\" 2021",
                Description = "M1 Max, 10-ядерный процессор, 32 ГБ ОЗУ, 1 ТБ памяти, экран Retina", Price = 319990M,
                Quantity = 50
            },
            new()
            {
                Id = 8, Name = "Фитнес-браслет Xiaomi Mi Band 6",
                Description = "Экран AMOLED, мониторинг сердечного ритма и сна, 30 дней автономной работы",
                Price = 3490M, Quantity = 200
            },
            new()
            {
                Id = 9, Name = "Наушники Sony WH-1000XM4",
                Description = "Беспроводные, шумоподавление, до 30 часов работы от аккумулятора", Price = 26990M,
                Quantity = 150
            },
            new()
            {
                Id = 10, Name = "Игровая приставка Sony PlayStation 5",
                Description = "SSD на 825 ГБ, поддержка 4K, HDR и 120 FPS, контроллер DualSense", Price = 49990M,
                Quantity = 70
            },
            new()
            {
                Id = 11, Name = "Умные часы Apple Watch Series 7",
                Description = "44 мм, always-on Retina экран, новые датчики и функции, 18 часов работы от аккумулятора",
                Price = 33990M, Quantity = 120
            },
            new()
            {
                Id = 12, Name = "Фотоаппарат Canon EOS R6",
                Description = "20 МП полнокадровый сенсор, 4K видео, встроенная стабилизация, Wi-Fi", Price = 159990M,
                Quantity = 30
            },
            new()
            {
                Id = 13, Name = "Электросамокат Xiaomi Mi Electric Scooter 3",
                Description = "30 км/ч скорость, 600 Вт мотор, 30 км дальность, вес 13,5 кг", Price = 42990M,
                Quantity = 50
            },
            new()
            {
                Id = 14, Name = "Смартфон Apple iPhone 13 Pro",
                Description = "6,1 дюймовый экран, A15 Bionic, 5G, камера 12 МП", Price = 99990M, Quantity = 80
            }
        };

        Orders = new List<Order>
        {
            new()
            {
                Id = 1, CustomerName = "John Smith",
                Products = new List<Product> { Products[0], Products[3], Products[4] }
            },
            new()
            {
                Id = 2, CustomerName = "Jane Doe",
                Products = new List<Product> { Products[2], Products[7], Products[8] }
            },
            new()
            {
                Id = 3, CustomerName = "Bob Johnson",
                Products = new List<Product> { Products[1], Products[5], Products[6] }
            },
            new()
            {
                Id = 4, CustomerName = "Alice Lee",
                Products = new List<Product> { Products[9], Products[10], Products[11] }
            },
            new()
            {
                Id = 5, CustomerName = "Mike Brown",
                Products = new List<Product> { Products[12], Products[13], Products[2] }
            }
        };
    }
}