using Store;

class Program
{
    static void Main()
    {
        Shop store = new Shop();

        store.AddProduct(new Toy { Name = "Мишка", Price = 500.00m, Material = "Плюш" });
        store.AddProduct(new Meat { Name = "Курица", Price = 150.00m, Weight = 1.5 });
        store.AddProduct(new Drinks { Name = "Кола", Price = 75.50m, Volume = 500 });
        store.AddProduct(new Electronics { Name = "Телефон", Price = 29999.99m, WarrantyPeriod = 24 });
        store.AddProduct(new Clothing { Name = "Футболка", Price = 600.00m, Size = "M" });

        // Отображение товаров со скидкой 10%
        store.DisplayProductsWithDiscount(10);
    }
}