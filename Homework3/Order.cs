namespace Homework3;

public class Order
{
    public Order(string orderName, decimal price)
    {
        if (string.IsNullOrEmpty(orderName))
            throw new ArgumentException("Name of the order is required to be not null or empty");
        if (price <= 0)
            throw new ArgumentException("Price cannot be less than zero");

        OrderName = orderName;
        Price = price;
    }

    public string OrderName { get; }
    public decimal Price { get; }

    public override string ToString()
    {
        return $"{OrderName} that costs {Price}";
    }
}
