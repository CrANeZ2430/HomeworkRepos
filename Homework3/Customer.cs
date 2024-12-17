namespace Homework3;

public class Customer
{
    public Customer(string firstName, string lastName, string address, Order order)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(address))
            throw new ArgumentException("First name, last name and address are required to be not null or empty");

        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Order = order;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Address { get; }
    public Order Order { get; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ordered {Order}";
    }
}
