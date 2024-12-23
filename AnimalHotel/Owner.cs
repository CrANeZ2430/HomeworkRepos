namespace AnimalHotel;

public class Owner(string name, byte age, string phoneNumber)
{
    public string Name { get; set; } = name;
    public byte Age { get; set; } = age;
    public string PhoneNumber { get; set; } = phoneNumber;
}
