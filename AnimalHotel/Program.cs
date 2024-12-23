using AnimalHotel;
using AnimalHotel.Animals;
using AnimalHotel.Hotel;

var animalNames = new string[] { "Dog", "Cat", "Parrot", "Horse" };
var ownerNames = new string[] { "John", "Jane", "Jack", "Jill" };
var ownerPhoneNumbers = new string[] { "1234567890", "0987654321", "6789054321", "1234509876" };
var random = new Random();

var genericHotel = new GenericHotel<IAnimal>();
var romashkaHotel = new RomashkaHotel();
var kyivHotel = new KyivHotel();

for (var i = 0; i < 10; i++)
{
    var animalName = animalNames[random.Next(animalNames.Length)];
    var ownerName = ownerNames[random.Next(ownerNames.Length)];
    var ownerPhoneNumber = ownerPhoneNumbers[random.Next(ownerPhoneNumbers.Length)];
    var animalType = random.Next(2);

    var owner = new Owner(ownerName, ownerPhoneNumber);
    IAnimal animal = animalType switch
    {
        0 => AnimalFactory.CreateDog(animalName, owner),
        1 => AnimalFactory.CreateCat(animalName, owner),
        _ => throw new ArgumentException("Invalid animal type")
    };

    genericHotel.AddAnimal(animal);
    romashkaHotel.AddAnimal(animal);
    kyivHotel.AddAnimal(animal);
}
