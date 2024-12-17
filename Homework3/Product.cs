namespace Homework3;

public class Product
{
    public Product(string name, decimal price, string category)
    {
        if (string.IsNullOrWhiteSpace(name) || price <= 0 || string.IsNullOrWhiteSpace(category))
            throw new ArgumentException("Name and category are required to be not null or empty");
        if (price <= 0)
            throw new ArgumentException("Price must be greater than 0");

        Name = name;
        Price = price;
        Category = category;
    }

    public string Name { get; }
    public decimal Price { get; }
    public string Category { get; }
}
